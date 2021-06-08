using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Dtos
{
    public class DepositoDto
    {
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string horarios { get; set; }
        public UbicacionDto ubicacion { get; set; }
    }
}
