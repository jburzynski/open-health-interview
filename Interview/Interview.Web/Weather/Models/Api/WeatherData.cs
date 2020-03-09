using System.Collections.Generic;

namespace Interview.Web.Weather.Models.Api
{
    public class WeatherData
    {
        public IEnumerable<WeatherPoint> List { get; set; }
    }
}