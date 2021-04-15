using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TournamentTracker.Shared.Models;

namespace TournamentTracker.Client.Data
{
    public class PrizeService : IPrizeService
    {

        private readonly HttpClient _httpClient;

        public PrizeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async void CreatePrize(Prize prize)
        {
            await _httpClient.PostAsJsonAsync<Prize>("api/Prize", prize);
        }
    
    }
}
