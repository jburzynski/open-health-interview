using System.Collections.Generic;
using System.Threading.Tasks;
using Interview.Web.Weather.Models.Dto;

namespace Interview.Web.Weather
{
    public interface IWeatherDataService
    {
        Task<IEnumerable<WeatherPointDto>> GetWeatherDataAsync(string location);
    }
}