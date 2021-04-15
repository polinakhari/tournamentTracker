using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using TournamentTracker.Shared.Models;


namespace TournamentTracker.Client.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _httpClient;

        public EmployeeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //public async Task<IEnumerable<Employee>> GetEmployees()
        //{
        //    return await _httpClient.GetFromJsonAsync<Employee[]>("api/employees");
        //}
    }
}
