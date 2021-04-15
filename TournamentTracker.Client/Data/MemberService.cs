using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TournamentTracker.Shared.Models;

namespace TournamentTracker.Client.Data
{
    public class MemberService : IMemberService
    {

        private readonly HttpClient _httpClient;

        public MemberService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Person>> GetMembers()
        {
            return await _httpClient.GetFromJsonAsync<List<Person>>("api/Member");
        }

        public async Task CreateMember(Person member)
        {
            await _httpClient.PostAsJsonAsync<Person>("api/Member", member);
        }
        public async Task EditMember(Person member)
        {
            await _httpClient.PostAsJsonAsync<Person>("api/Member/edit", member);
        }

    }
}
