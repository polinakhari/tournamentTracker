using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TournamentTracker.Shared.Models;

namespace TournamentTracker.Client.Data
{
    public class TeamService : ITeamService
    {

        private readonly HttpClient _httpClient;

        public TeamService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Team> CreateTeam(Team Team)
        {
            return await (await _httpClient.PostAsJsonAsync<Team>("api/Team", Team)).Content.ReadFromJsonAsync<Team>();
        }

        public async Task<List<Team>> GetTeams()
        {
            return await _httpClient.GetFromJsonAsync<List<Team>>("api/Team");
        }
        public async Task EditTeam(Team team)
        {
            await _httpClient.PostAsJsonAsync<Team>("api/Member/edit", team);
        }

    }
}
