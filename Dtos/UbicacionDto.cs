using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EstacionamientoMedido.Dtos
{
    public class UbicacionDto
    {
        [JsonProperty(PropertyName = "lat")]
        public double lat { get; set; }
        [JsonProperty(PropertyName = "lon")]
        public double lon { get; set; }
    }
}
