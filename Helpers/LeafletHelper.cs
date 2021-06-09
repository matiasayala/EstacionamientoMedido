using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstacionamientoMedido.Entities;
using FisSst.BlazorMaps;
using Microsoft.AspNetCore.Components;

namespace EstacionamientoMedido.Helpers
{
    public static class LeafletHelper
    {
        [Inject] private static IIconFactory IconFactory { get; set; }
        public static  List<LatLng> ToLeafletLatLng(this List<LatLong> Vertices)
        {
            var list = new List<LatLng>();
            foreach (var item in Vertices)
            {
                list.Add(new LatLng() { Alt = 0, Lat = item.Latitud, Lng = item.Longitud });
            }
            return list;
        }       
        public static MarkerOptions IconOcupado()
        {
            var IconOcupado = new IconOptions()
            {
            IconUrl = "http://leafletjs.com/examples/custom-icons/leaf-green.png",
            IconSize = new Point(38, 95),
            IconAnchor = new Point(22, 94),
            ShadowUrl = "http://leafletjs.com/examples/custom-icons/leaf-shadow.png",
            ShadowSize = new Point(50, 64),
            ShadowAnchor = new Point(4, 61),
            PopupAnchor = new Point(-3, -76),
        };
        var marker = new MarkerOptions()
        {
            Opacity = 0.5,
            Draggable = true,
            IconRef = IconFactory.Create(IconOcupado).Result,
        };
            return marker;
        }
    }
}
