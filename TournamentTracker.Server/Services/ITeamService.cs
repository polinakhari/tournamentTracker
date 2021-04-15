using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentTracker.BD.Models;

namespace TournamentTracker.Server.Services
{
    public interface ITeamService
    {
        Task<Team> CreateTeam(Team Team);
        Task<Team> GetTeam(int id);
        Task<List<Team>> GetTeams();
        Task DeleteTeam(int id);
        Task EditTeam(Team Team);

    }
}
