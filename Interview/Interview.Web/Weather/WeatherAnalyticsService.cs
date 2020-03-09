﻿using System.Collections.Generic;
using System.Linq;
using Interview.Web.Weather.Models;
using Interview.Web.Weather.Models.Dto;

namespace Interview.Web.Weather
{
    public class WeatherAnalyticsService : IWeatherAnalyticsService
    {
        private IWeatherDataService _weatherDataService;

        public WeatherAnalyticsService(IWeatherDataService weatherDataService)
        {
            _weatherDataService = weatherDataService;
        }

        public IEnumerable<DailyWeather> GetDailyWeather(IEnumerable<WeatherPointDto> points) =>
            points.GroupBy(x => x.DateTime.Date)
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