using System;
using System.Linq;
using Interview.Web.Utils;
using Interview.Web.Weather.Models.Api;
using Interview.Web.Weather.Models.Dto;

namespace Interview.Web.Weather.Models.Mapping
{
    public class Mapper
    {
        public WeatherPointDto Map(WeatherPoint obj)
        {
            return new WeatherPointDto
            {
                DateTime = DateUtils.FromUnixSeconds(obj.Dt),
                Temperature = obj.Main.Temp.KtoC(),
                Description = obj.Weather.Single().Description,
                Icon = obj.Weather.Single().Icon
            };
        }
    }
}