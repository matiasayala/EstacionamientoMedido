using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionamientoMedido.Entities;

namespace EstacionamientoMedido.Helpers
{
    public static class PolygonHelper
    {
        public static bool ContainsVertice(this List<LatLong> verticesZona, LatLong vertice)
        {
            double minX = verticesZona[0].Latitud;
            double maxX = verticesZona[0].Latitud;
            double minY = verticesZona[0].Longitud;
            double maxY = verticesZona[0].Longitud;
            for (int i = 1; i < verticesZona.Count; i++)
            {
                LatLong q = verticesZona[i];
                minX = Math.Min(q.Latitud, minX);
                maxX = Math.Max(q.Latitud, maxX);
                minY = Math.Min(q.Longitud, minY);
                maxY = Math.Max(q.Longitud, maxY);
            }

            if (vertice.Latitud < minX || vertice.Latitud > maxX || vertice.Longitud < minY || vertice.Longitud > maxY)
            {
                return false;
            }

            // https://wrf.ecse.rpi.edu/Research/Short_Notes/pnpoly.html
            bool inside = false;
            for (int i = 0, j = verticesZona.Count - 1; i < verticesZona.Count; j = i++)
            {
                if ((verticesZona[i].Longitud > vertice.Longitud) != (verticesZona[j].Longitud > vertice.Longitud) &&
                     vertice.Latitud < (verticesZona[j].Latitud - verticesZona[i].Latitud) * (vertice.Longitud - verticesZona[i].Longitud) / (verticesZona[j].Longitud - verticesZona[i].Longitud) + verticesZona[i].Latitud)
                {
                    inside = !inside;
                }
            }

            return inside;
        }
    }
}
