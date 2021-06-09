using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Models
{
    public class Deposito
    {
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Horarios { get; set; }
        public Lugar Ubicacion { get; set; }
    }
}
