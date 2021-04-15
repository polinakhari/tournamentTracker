using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TournamentTracker.Shared.Models;

namespace TournamentTracker.Client.Data
{
    public class TournamentService : ITournamentService
    {

        private readonly HttpClient _httpClient;

        public TournamentService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Tournament> CreateTournament(Tournament Tournament)
        {
            return await (await _httpClient.PostAsJsonAsync<Tournament>("api/Tournament", Tournament)).Content.ReadFromJsonAsync<Tournament>();
        }

        public async Task<List<Tournament>> GetTournaments()
        {
            return await _httpClient.GetFromJsonAsync<List<Tournament>>("api/Tournament");
        }
        public async Task EditTournament(Tournament Tournament)
        {
            await _httpClient.PostAsJsonAsync<Tournament>("api/Member/edit", Tournament);
        }

    }
}
