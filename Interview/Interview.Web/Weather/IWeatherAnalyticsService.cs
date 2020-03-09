using System.Collections.Generic;
using Interview.Web.Weather.Models;
using Interview.Web.Weather.Models.Dto;

namespace Interview.Web.Weather
{
    public interface IWeatherAnalyticsService
    {
        IEnumerable<DailyWeather> GetDailyWeather(IEnumerable<WeatherPointDto> points);
    }
}