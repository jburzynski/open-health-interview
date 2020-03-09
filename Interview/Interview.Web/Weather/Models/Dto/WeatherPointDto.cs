using System;

namespace Interview.Web.Weather.Models.Dto
{
    public class WeatherPointDto
    {
        public DateTime DateTime { get; set; }
        public int Temperature { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}