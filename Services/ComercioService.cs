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
        public List<Comercio> GetComerciosCercanos()
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
                Id = 2,
                Latitud = -34.523016,
                Longitud = -58.702522,
                Nombre = "Nada en su lugar",
                HorarioAtencion = "11hs a 16hs",
                Rubro = "Libreria",
                Direccion = "Juan María Gutiérrez 912, B1613 Los Polvorines, Provincia de Buenos Aires",
                Localidad = "Polvorines"
            };

            var stopKiosco = new Comercio()
            {
                Id = 3,
                Latitud = -34.5212694956474,
                Longitud = -58.70118263173153,
                Nombre = "Stop Kiosco",
                HorarioAtencion = "11hs a 16hs",
                Rubro = "Kiosco",
                Direccion = "Juan María Gutiérrez 1098-1050, B1613GSV, B1613GSV Los Polvorines, Provincia de Buenos Aires",
                Localidad = "Polvorines"
            };

            var unoBarberia = new Comercio()
            {
                Id = 4,
                Latitud = -34.52138934236681,
                Longitud = -58.701735379774085,
                Nombre = "Uno Barberia",
                HorarioAtencion = "11hs a 16hs",
                Rubro = "Peluqueria",
                Direccion = "Dr. Juan A. Mazza, B1613 Los Polvorines, Provincia de Buenos Aires",
                Localidad = "Polvorines"
            };

            var rapipago = new Comercio()
            {
                Id = 5,
                Latitud = -34.521820789128945,
                Longitud = -58.70165780110145,
                Nombre = "Rapipago",
                HorarioAtencion = "11hs a 16hs",
                Rubro = "Cobro de Deudas",
                Direccion = "Juan María Gutiérrez 1035, B1613GSV Los Polvorines, Provincia de Buenos Aires",
                Localidad = "Polvorines"
            };

            var loDeCarmen = new Comercio()
            {
                Id = 6,
                Latitud = -34.521836768595755,
                Longitud = -58.70398516128056,
                Nombre = "Lo De Carmen",
                HorarioAtencion = "11hs a 16hs",
                Rubro = "Almacen",
                Direccion = "GQT Los Polvorines Buenos Aires AR, Carlos Pellegrini 920, B1613",
                Localidad = "Polvorines"
            };

            var vivero = new Comercio()
            {
                Id = 7,
                Latitud = -34.52278496899766,
                Longitud = -58.702229506979876,
                Nombre = "Vivero",
                HorarioAtencion = "11hs a 16hs",
                Rubro = "Vivero",
                Direccion = "Juan María Gutiérrez 1035, B1613GSV Los Polvorines, Provincia de Buenos Aires",
                Localidad = "Polvorines"
            };

            var maxikiosco = new Comercio()
            {
                Id = 8,

                Latitud = -34.51924234345172,
                Longitud = -58.70386745380939,
                Nombre = "Maxikiosco",
                HorarioAtencion = "11hs a 16hs",
                Rubro = "Kiosco",
                Direccion = "Dr. Juan A. Mazza 2346, B1613CKK Los Polvorines, Provincia de Buenos Aires",
                Localidad = "Polvorines"
            };

            var despensaMorena = new Comercio()
            {
                Id = 9,
                Latitud = -34.51982658368867,
                Longitud = -58.70315339630862,
                Nombre = "Despensa Morena",
                HorarioAtencion = "11hs a 16hs",
                Rubro = "Despensa",
                Direccion = "Dr. Juan A. Mazza 2156, B1613CKF Los Polvorines, Provincia de Buenos Aires",
                Localidad = "Polvorines"
            };

            var despensaDeMary = new Comercio()
            {
                Id = 10,
                Latitud = -34.52362871394236,
                Longitud = -58.70887563804782,
                Nombre = "Despensa de Mary",
                HorarioAtencion = "11hs a 16hs",
                Rubro = "Despensa",
                Direccion = "Dante Alighieri 2260, B1613DDQ, B1613DDQ Los Polvorines, Provincia de Buenos Aires",
                Localidad = "Polvorines"
            };

            var celularesTecnocell = new Comercio()
            {
                Id = 11,
                Latitud = -34.521519443177056,
                Longitud = -58.7123278888633,
                Nombre = "Celulares Tecnocell",
                HorarioAtencion = "11hs a 16hs",
                Rubro = "Tienda",
                Direccion = "José Darragueira333, B1613GGG, B1613GGG Los Polvorines, Provincia de Buenos Aires",
                Localidad = "Polvorines"
            };

            var autoserviceNelly = new Comercio()
            {
                Id = 12,
                Latitud = -34.5163864663729,
                Longitud = -58.706610892629016,
                Nombre = "Autoservice Nelly",
                HorarioAtencion = "11hs a 16hs",
                Rubro = "Autoservice",
                Direccion = "José Colombres 2699-2601,B1613CHR, B1613CHR Los Polvorines, Provincia de Buenos Aires",
                Localidad = "Polvorines"
            };

            var comercios = new List<Comercio>()
            {
                kioscoLaMorocha,
                nadaEnSuLugar,
                stopKiosco,
                unoBarberia,
                rapipago,
                loDeCarmen,
                vivero,
                maxikiosco,
                despensaMorena,
                despensaDeMary,
                celularesTecnocell,
                autoserviceNelly
            };


            return comercios;
        }
    }

    //public async Task<Comercio> BuscarComercio()
}
