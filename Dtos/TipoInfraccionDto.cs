using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Dtos
{
    public class TipoInfraccionDto
    {
        public TipoDto tipo { get; set; }
    }
    public class TipoDto
    {
        public int id { get; set; }
        public string descripcion { get; set; }
    }

}
