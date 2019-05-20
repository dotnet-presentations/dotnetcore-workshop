using System;
using System.Device.Location;
using System.Threading.Tasks;

namespace Gps
{
    public static class GpsLocation
    {
        public static Task<(double latitude, double longitude)> GetCoordinates()
        {
            return Task.Run(async () =>
            {
                using (var watcher = new GeoCoordinateWatcher())
                {
                    watcher.TryStart(true, TimeSpan.FromSeconds(1));
                    while (watcher.Position.Location.IsUnknown)
                        await Task.Delay(TimeSpan.FromMilliseconds(100));

                    var location = watcher.Position.Location;
                    return (location.Latitude, location.Longitude);
                }
            });
        }
    }
}
