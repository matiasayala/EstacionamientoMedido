using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionamientoMedido.Entities;

namespace EstacionamientoMedido.Services
{
    public class ZonaService
    {
        public async Task<List<Zona>> GetZonas()
        {
            LatLong p1, p2, p3, p4;
            p1 = new LatLong()
            {
                Latitud = -34.52571569185439,
                Longitud = -58.693943913576135,
            };
            p2 = new LatLong()
            {
                Latitud = -34.53228606271314,
                Longitud = -58.701341821807084,
            };
            p3 = new LatLong()
            {
                Latitud = -34.52309810662177,
                Longitud = -58.713786207589216,
            };
            p4 = new LatLong()
            {
                Latitud = -34.515545762025475,
                Longitud = -58.70595525107695,
            };

            var zona1 = new Zona()
            {
                id = 1,
                Color = "Amarilla",
                Costo2hs = 10,
                Costo4hs = 15,
                Vertices = new List<LatLong>() { p1, p2, p3, p4 }
            };

            p1 = new LatLong()
            {
                Latitud = -34.525476655932394,
                Longitud = -58.69386598662112,
            };
            p2 = new LatLong()
            {
                Latitud = -34.518548941616125,
                Longitud = -58.688236358894144,
            };
            p3 = new LatLong()
            {
                Latitud = -34.507249287273964,
                Longitud = -58.70054214764837,
            };
            p4 = new LatLong()
            {
                Latitud = -34.51367243656924,
                Longitud = -58.70786788116488
            };

            var zona2 = new Zona()
            {
                id = 2,
                Color = "Violeta",
                Costo2hs = 7,
                Costo4hs = 11,
                Vertices = new List<LatLong>() { p1, p2, p3, p4 }
            };

            return new List<Zona>() { zona1, zona2 };
        }
    }
}
