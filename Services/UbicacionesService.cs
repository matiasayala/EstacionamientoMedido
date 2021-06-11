using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionamientoMedido.Entities;

namespace EstacionamientoMedido.Services
{
    public class UbicacionesService
    {
        public List<Ubicacion> GetUbicaciones()
        {
            Ubicacion u1;
            var result = new List<Ubicacion>();
            u1 = new Ubicacion()
            {
                Id = 1,
                Latitud = -34.531244356275124,
                Longitud = -58.70046997294684
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 2,
                Latitud = -34.53005517242589,
                Longitud = -58.70360957302534,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 3,
                Latitud = -34.528033520907314,
                Longitud = -58.70126389480577
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 4,
                Latitud = -34.52529826720581,
                Longitud = -58.701119545376876,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 5,
                Latitud = -34.526219938814315,
                Longitud = -58.702274340808046,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 6,
                Latitud = -34.52428738984282,
                Longitud = -58.695273393506554,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 7,
                Latitud = -34.52190880647475,
                Longitud = -58.69837690622784
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 8,
                Latitud = -34.52449551265582,
                Longitud = -58.701191720091316,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 9,
                Latitud = -34.521611478777864,
                Longitud = -58.70122780744854,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 10,
                Latitud = -34.5232170357328,
                Longitud = -58.70277956380917,
            };
            result.Add(u1);
            return result;
        }
    }
}
