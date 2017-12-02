using System.Data.Entity.Spatial;

namespace Cejen.Dominio.Utils
{
    public class LocationHelper
    {
        public static DbGeography RetornarLocation(decimal latitude, decimal longitude)
        {
            var text = string.Format("POINT({0} {1})", longitude, latitude);
            // 4326 is most common coordinate system used by GPS/Maps
            return DbGeography.PointFromText(text.Replace(',', '.'), 4326);
        }
    }
}