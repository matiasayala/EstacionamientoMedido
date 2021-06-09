using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FisSst.BlazorMaps;

namespace EstacionamientoMedido.Entities
{
    public class Zona
    {
        public int id { get; set; }
        public string Color { get; set; }
        public double Costo2hs { get; set; }
        public double Costo4hs { get; set; }
        public List<LatLong> Vertices { get; set; }

 
    }

    public class LatLong
    {
        public double Latitud { get; set; }
        public double Longitud { get; set; }
    }
}
