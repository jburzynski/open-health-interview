using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Interview.Web.Weather;
using Interview.Web.Weather.Models;
using Interview.Web.Weather.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Interview.Web.Components
{
    public class WeatherViewComponent : ViewComponent
    {
        private readonly IWeatherDataService _weatherDataService;
        private readonly IWeatherAnalyticsService _weatherAnalyticsService;

        public WeatherViewComponent(IWeatherDataService weatherDataService, IWeatherAnalyticsService weatherAnalyticsService)
        {
            _weatherDataService = weatherDataService;
            _weatherAnalyticsService = weatherAnalyticsService;
        }

        public async Task<IViewComponentResult> InvokeAsync(string location)
        {
            List<WeatherPointDto> weatherPoints = (await _weatherDataService.GetWeatherDataAsync(location)).ToList();
            List<DailyWeather> dailyWeathers = _weatherAnalyticsService.GetDailyWeather(weatherPoints, 3).ToList();
            
            return View(dailyWeathers);
        }
    }
}