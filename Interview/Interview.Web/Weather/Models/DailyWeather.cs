using System;

namespace Interview.Web.Weather.Models
{
    public class DailyWeather
    {
        public DateTime Date { get; set; }
        public int TemperatureMin { get; set; }
        public int TemperatureMax { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}