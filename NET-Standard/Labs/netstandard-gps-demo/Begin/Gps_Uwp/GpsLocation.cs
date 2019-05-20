using System;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;

namespace Gps
{
    public static class GpsLocation
    {
        public static async Task<(double latitude, double longitude)> GetCoordinates()
        {
            var locator = new Geolocator();
            var position = await locator.GetGeopositionAsync();
            var latitude = position.Coordinate.Point.Position.Latitude;
            var longitude = position.Coordinate.Point.Position.Longitude;
            return (latitude, longitude);
        }
    }
}
