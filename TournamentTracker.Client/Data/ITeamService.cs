using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentTracker.Shared.Models;

namespace TournamentTracker.Client.Data
{
    public interface ITeamService
    {
        Task<Team> CreateTeam(Team team);
        Task<List<Team>> GetTeams();
        Task EditTeam(Team team);
    }
}
