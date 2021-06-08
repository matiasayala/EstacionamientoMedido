using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstacionamientoMedido.Dtos
{
    public class AcarreoDto
    {
        public AcarreoDto2 acarreo { get; set; }
    }

    public class AcarreoDto2
    {
        public DepositoDto deposito { get; set; }
    }
}
