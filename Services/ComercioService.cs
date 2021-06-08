using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionamientoMedido.Dtos;
using EstacionamientoMedido.Entities;
using EstacionamientoMedido.Models;
using FisSst.BlazorMaps;


namespace EstacionamientoMedido.Services
{
    public class ComercioService
    {
        public async Task<List<Comercio>> GetComerciosCercanos()
        {
            var kioscoLaMorocha = new Comercio()
            {
                Id = 1,
                Latitud = -34.520887,
                Longitud = -58.702172,
                Nombre = "Kiosco la Morocha",
                HorarioAtencion = "9hs a 18hs",
                Rubro = "Kiosco",
                Direccion = "CKF Los Polvorines Buenos Aires AR Doctor Juan A. Mazza 2000-2198, Maza 2040, B1613 Los Polvorines, Provincia de Buenos Aires",
                Localidad = "Polvorines"
            };

            var nadaEnSuLugar = new Comercio()
            {
                Id = 1,
                Latitud = -34.523016,
                Longitud = -58.702522,
                Nombre = "Nada en su lugar",
                HorarioAtencion = "11hs a 16hs",
                Rubro = "Libreria",
                Direccion = "Juan María Gutiérrez 912, B1613 Los Polvorines, Provincia de Buenos Aires",
                Localidad = "Polvorines"
            };


            var comercios = new List<Comercio>() { kioscoLaMorocha, nadaEnSuLugar };

            return await Task.FromResult(comercios);
        }
    }

    //public async Task<Comercio> BuscarComercio()
}
