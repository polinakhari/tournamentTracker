using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace TournamentTracker.Client.Data
{
    public class WeatherForecastService
    {
       
        private readonly HttpClient _httpClient;

        public WeatherForecastService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            return await _httpClient.GetFromJsonAsync<WeatherForecast[]>($"api/WeatherForecast/{startDate}");
        }
    }
}
