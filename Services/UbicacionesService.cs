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
            u1 = new Ubicacion()
            {
                Id = 11,
                Latitud = -34.524971219989794,
                Longitud = -58.70465610638484,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 12,
                Latitud = -34.52648751898377,
                Longitud = -58.70638829953159,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 13,
                Latitud = -34.52556585033643,
                Longitud = -58.707651357034436,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 14,
                Latitud = -34.52452524444204,
                Longitud = -58.70895050187406,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 15,
                Latitud = -34.52229533076836,
                Longitud = -58.70844527874372,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 16,
                Latitud = -34.518519207691945,
                Longitud = -58.706965697097516,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 17,
                Latitud = -34.51843000586476,
                Longitud = -58.703717834947355,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 18,
                Latitud = -34.522726452043166,
                Longitud = -58.7048365430213,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 19,
                Latitud = -34.52556585033643,
                Longitud = -58.707651357034436,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 20,
                Latitud = -34.52355895577627,
                Longitud = -58.708950501744845,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 20,
                Latitud = -34.52355895577627,
                Longitud = -58.708950501744845,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 21,
                Latitud = -34.521418215080075,
                Longitud = -58.70389827173347,
            };
            u1 = new Ubicacion()
            {
                Id = 22,
                Latitud = -34.5205856899332,
                Longitud = -58.70761526951356,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 23,
                Latitud = -34.52242912724686,
                Longitud = -58.70750700744189,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 24,
                Latitud = -34.521745276229105,
                Longitud = -58.700506060140405,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 25,
                Latitud = -34.528167308122,
                Longitud = -58.697294285444364,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 26,
                Latitud = -34.520793822040346,
                Longitud = -58.70032562347057,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 27,
                Latitud = -34.516541878064785,
                Longitud = -58.69837690625798,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 28,
                Latitud = -34.51487672202208,
                Longitud = -58.700361710905305,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 29,
                Latitud = -34.51906928345335,
                Longitud = -58.69530948091007,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 30,
                Latitud = -34.52049649027443,
                Longitud = -58.69368554983498,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 31,
                Latitud = -34.518563808507416,
                Longitud = -58.6899685520409,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 32,
                Latitud = -34.52153714649981,
                Longitud = -58.69227814290324,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 33,
                Latitud = -34.50661059638851,
                Longitud = -58.69978820043089,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 34,
                Latitud = -34.505372817320136,
                Longitud = -58.70948706817472,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 35,
                Latitud = -34.51103108585704,
                Longitud = -58.69583998878295,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 36,
                Latitud = -34.51276385375543,
                Longitud = -58.68845854961507,
            };
            result.Add(u1);
            u1 = new Ubicacion()
            {
                Id = 37,
                Latitud = -34.51972361250297,
                Longitud = -58.69457553371207,
            };
            result.Add(u1);
            return result;
        }
    }
}
