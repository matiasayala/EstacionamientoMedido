using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Entities
{
    public class Comercio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Rubro { get; set; }
        public string Direccion { get; set; }
        public string HorarioAtencion { get; set; }
        public string Localidad { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
    }
}
