using System;
using System.Threading.Tasks;

namespace Gps
{
    public static class GpsLocation
    {
        public static async Task<(double latitude, double longitude)> GetCoordinates()
        {
#if NET461
            return await Task.Run(async () =>
            {
                using (var watcher = new System.Device.Location.GeoCoordinateWatcher())
                {
                    watcher.TryStart(true, TimeSpan.FromSeconds(1));
                    while (watcher.Position.Location.IsUnknown)
                        await Task.Delay(TimeSpan.FromMilliseconds(100));

                    var location = watcher.Position.Location;
                    return (location.Latitude, location.Longitude);
                }
            });
#elif WINDOWS_UWP
    var locator = new Windows.Devices.Geolocation.Geolocator();
    var position = await locator.GetGeopositionAsync();
    var latitude = position.Coordinate.Point.Position.Latitude;
    var longitude = position.Coordinate.Point.Position.Longitude;
    return (latitude, longitude);
#else
            throw new PlatformNotSupportedException();
#endif
        }
    }
}
