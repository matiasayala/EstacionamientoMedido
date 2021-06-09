using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Filters
{
    public class InfraccionFilter
    {
        public string Patente { get; set; }
        public DateTime? DateRegistroFrom { get; set; }
        public DateTime? DateRegistroTo { get; set; }
        public bool Acarreo { get; set; }
        public string Direccion { get; set; }
        public string Tipo { get; set; }
    }
}

