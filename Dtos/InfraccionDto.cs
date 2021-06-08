using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EstacionamientoMedido.Dtos
{
    public class InfraccionDto
    {
        public int id { get; set; }
        public string patente { get; set; }
        public string fechaHoraRegistro { get; set; }
        public string fechaHoraActualizacion { get; set; }
        public string direccionRegistrada { get; set; }
        public int tipoInfraccion { get; set; }
        public string montoAPagar { get; set; }
        public bool existeAcarreo { get; set; }
    }

    public class InfraccionesDto
    {
        public string patente { get; set; }
        public InfraccionDto[] infracciones { get; set; }
    }

}
