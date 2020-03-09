using System.Collections.Generic;
using System.Linq;
using Interview.Web.Weather.Models;
using Interview.Web.Weather.Models.Dto;

namespace Interview.Web.Weather
{
    public class WeatherAnalyticsService : IWeatherAnalyticsService
    {
        public IEnumerable<DailyWeather> GetDailyWeather(IEnumerable<WeatherPointDto> points, int dayLimit) =>
            points.GroupBy(x => x.DateTime.Date)
                .Take(dayLimit)
                .Select(g => new DailyWeather
                {
                    Date = g.Key,
                    TemperatureMin = g.Min(x => x.Temperature),
                    TemperatureMax = g.Max(x => x.Temperature),
                    Description = g.First().Description,
                    Icon = g.First().Icon
                });
    }
}