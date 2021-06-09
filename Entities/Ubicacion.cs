using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Entities
{
    public class Ubicacion
    {
        public int Id { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }
        public Zona Zona { get; set; }
        public Reserva Reserva { get; set; }

    }
}
