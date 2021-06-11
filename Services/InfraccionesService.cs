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
using EstacionamientoMedido.Filters;

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

        public async Task<List<Infraccion>> GetInfracciones(InfraccionFilter infraccionFilter)
        {
            if (string.IsNullOrWhiteSpace(infraccionFilter.Patente))
                return new List<Infraccion>();

            var infracciones = await _HttpClient.GetFromJsonAsync<InfraccionesDto>($"{_BaseUrl}/{infraccionFilter.Patente}/infracciones");
            var tiposInfraccion = await GetTiposInfraccionList();
            //var tiposInfraccion = await _HttpClient.GetFromJsonAsync<TipoInfraccionDto[]>($"{_BaseUrl}/tiposInfraccion/");

            var response = new List<Infraccion>();
            foreach (var infraccion in infracciones.infracciones)
            {
                var tipoInfraccion = tiposInfraccion.FirstOrDefault(x => x.id == infraccion.tipoInfraccion);
                response.Add(new Infraccion()
                {
                    Id = infraccion.id,
                    Patente = infraccion.patente,
                    DireccionRegistrada = infraccion.direccionRegistrada,
                    FechaHoraActualizacion = infraccion.fechaHoraActualizacion,
                    FechaHoraRegistro = infraccion.fechaHoraRegistro,
                    MontoAPagar = infraccion.montoAPagar,
                    TipoInfraccion = tipoInfraccion.descripcion,
                    IdTipoInfraccion = tipoInfraccion.id,                    
                    existeAcarreo = infraccion.existeAcarreo
                });
            }

            //var response2 = infracciones.infracciones.Select(infraccion => new Infraccion()
            //{
            //    Id = infraccion.id,
            //    Patente = infraccion.patente,
            //    DireccionRegistrada = infraccion.direccionRegistrada,
            //    FechaHoraActualizacion = infraccion.fechaHoraActualizacion,
            //    FechaHoraRegistro = infraccion.fechaHoraRegistro,
            //    MontoAPagar = infraccion.montoAPagar,
            //    TipoInfraccion = tiposInfraccion.FirstOrDefault(x => x.id == infraccion.tipoInfraccion).descripcion,
            //    //TipoInfraccion = await GetTipoInfraccion(infraccion.tipoInfraccion),
            //    existeAcarreo = infraccion.existeAcarreo
            //    //Deposito = infraccion.existeAcarreo ? await GetDepositoAcarreo(infraccion.patente, infraccion.id) : null
            //});

            bool FiltroIdTipoInfraccion(Infraccion x) => infraccionFilter.IdTipoInfraccion != -1 ? x.IdTipoInfraccion == infraccionFilter.IdTipoInfraccion : true;

            bool FiltroDireccion(Infraccion x) => !string.IsNullOrWhiteSpace(infraccionFilter.Direccion) ? x.DireccionRegistrada.ToLower().Contains(infraccionFilter.Direccion.ToLower()) : true;

            bool FiltroDateRegistro(Infraccion x) => infraccionFilter.DateRegistroFrom != null && infraccionFilter.DateRegistroTo != null ? DateTime.Parse(x.FechaHoraRegistro) > infraccionFilter.DateRegistroFrom && DateTime.Parse(x.FechaHoraRegistro) < infraccionFilter.DateRegistroTo : true;

            return response.Where(x => FiltroIdTipoInfraccion(x) && FiltroDireccion(x) && FiltroDateRegistro(x)).ToList();
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

        public async Task<List<TipoDto>> GetTiposInfraccionList()
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
