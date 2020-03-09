using System.Collections.Generic;

namespace Interview.Web.Weather.Models.Api
{
    public class WeatherPoint
    {
        public long Dt { get; set; }
        public Main Main { get; set; }
        public IEnumerable<Weather> Weather { get; set; }
    }
}