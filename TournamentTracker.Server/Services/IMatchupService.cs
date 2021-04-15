using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentTracker.BD.Models;

namespace TournamentTracker.Server.Services
{
    public interface IMatchupService
    {
        Task<Matchup> CreateMatchup(Matchup matchup);
        Task<Matchup> GetMatchup(int id);
        Task<List<Matchup>> GetMatchups();
        void DeleteMatchup(int id);
        void EditMatchup(Matchup matchup);

    }
}
