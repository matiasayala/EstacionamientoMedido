using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using EstacionamientoMedido.Dtos;
using EstacionamientoMedido.Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Linq;


namespace EstacionamientoMedido.Services
{
    public class InfraccionesService
    {
        private readonly string _BaseUrl = "/api";
        private readonly HttpClient _HttpClient;
        public InfraccionesService(HttpClient httpClient)
        {
            _HttpClient = httpClient;
        }

        public async Task<List<Infraccion>> GetInfracciones(string patente)
        {
            if (string.IsNullOrWhiteSpace(patente))
                return null;

            var infracciones = await _HttpClient.GetFromJsonAsync<InfraccionesDto>($"{_BaseUrl}/{patente}/infracciones");
            var tiposInfraccion = await GetTiposInfraccionList();
            //var tiposInfraccion = await _HttpClient.GetFromJsonAsync<TipoInfraccionDto[]>($"{_BaseUrl}/tiposInfraccion/");


            var response = await Task.WhenAll(infracciones.infracciones.Select(async infraccion => new Infraccion()
            {
                Id = infraccion.id,
                Patente = infraccion.patente,
                DireccionRegistrada = infraccion.direccionRegistrada,
                FechaHoraActualizacion = infraccion.fechaHoraActualizacion,
                FechaHoraRegistro = infraccion.fechaHoraRegistro,
                MontoAPagar = infraccion.montoAPagar,
                TipoInfraccion = tiposInfraccion.FirstOrDefault(x => x.id == infraccion.tipoInfraccion).descripcion,
                //TipoInfraccion = await GetTipoInfraccion(infraccion.tipoInfraccion),
                existeAcarreo = infraccion.existeAcarreo
                //Deposito = infraccion.existeAcarreo ? await GetDepositoAcarreo(infraccion.patente, infraccion.id) : null
            }));

            return response.ToList();
        }

        public async Task<Deposito> GetDepositoAcarreo(string patente, int idInfraccion)
        {
            //var response = await _HttpClient.GetAsync($"{_BaseUrl}/{patente}/acarreos/{idInfraccion}/");
            //var asd = JsonConvert.DeserializeObject(response) ["acarreo"].ToList();
            //var response = await _HttpClient.GetFromJsgeonAsync($"{_BaseUrl}/{patente}/acarreos/{idInfraccion}/");
            //string Content = await response. .ReadAsStringAsync();

            AcarreoDto product = null;
            HttpResponseMessage response = await _HttpClient.GetAsync($"{_BaseUrl}/{patente}/acarreos/{idInfraccion}");
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<AcarreoDto>();
            } 

            var acarreo = product.acarreo.deposito;
            var ubicacion = new Lugar()
            {
                Latitud = acarreo.ubicacion.lat,
                Longitud = acarreo.ubicacion.lon
            };

            var acarreo2 = new Deposito()
            {
                Nombre = acarreo.nombre,
                Direccion = acarreo.direccion,
                Ubicacion = ubicacion,
                Telefono = acarreo.telefono,
                Horarios = acarreo.horarios
            };

            return acarreo2;
        }

        private async Task<string> GetTipoInfraccion(int idTipoInfraccion)
        {
            TipoInfraccionDto infraccion = null;
            HttpResponseMessage response = await _HttpClient.GetAsync($"{_BaseUrl}/tiposInfraccion/{idTipoInfraccion}");
            if (response.IsSuccessStatusCode)
            {
                infraccion = await response.Content.ReadAsAsync<TipoInfraccionDto>();
            }
            return infraccion.tipo.descripcion;
        }

        private async Task<List<TipoDto>> GetTiposInfraccionList()
        {
            TiposInfraccionDto tiposInfraccion = null;
            HttpResponseMessage response = await _HttpClient.GetAsync($"{_BaseUrl}/tiposInfraccion");
            if (response.IsSuccessStatusCode)
            {
                tiposInfraccion = await response.Content.ReadAsAsync<TiposInfraccionDto>();
            }

            return tiposInfraccion.tipos.Select(x => new TipoDto() { id = x.id, descripcion = x.descripcion }).ToList();
        }

    }
}
