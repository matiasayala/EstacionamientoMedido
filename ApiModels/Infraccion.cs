using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Models
{
    public class Infraccion
    {
        public int Id { get; set; }
        public string Patente { get; set; }
        public string FechaHoraRegistro { get; set; }
        public string FechaHoraActualizacion { get; set; }
        public string DireccionRegistrada { get; set; }
        public string TipoInfraccion { get; set; }
        public string MontoAPagar { get; set; }
        public bool existeAcarreo { get; set; }
    }
}

