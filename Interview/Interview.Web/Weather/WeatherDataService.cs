﻿using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Interview.Web.Weather.Models.Api;
using Interview.Web.Weather.Models.Dto;
using Interview.Web.Weather.Models.Mapping;
using Newtonsoft.Json;

namespace Interview.Web.Weather
{
    public class WeatherDataService : IWeatherDataService
    {
        public async Task<IEnumerable<WeatherPointDto>> GetWeatherDataAsync(string location)
        {
            string uri = $"http://api.openweathermap.org/data/2.5/forecast?q={location}&appid=aee80a0008f2439f4524b4788f061088";

            using var client = new HttpClient();
            
            HttpResponseMessage response = await client.GetAsync(uri);
            string content = await response.Content.ReadAsStringAsync();

            var data = JsonConvert.DeserializeObject<WeatherData>(content);
            var mapper = new Mapper();

            return data.List.Select(mapper.Map);
        }
    }
}