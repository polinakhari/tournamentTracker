using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentTracker.BD.Models;

namespace TournamentTracker.Server.Services
{
    public interface ITournamentService
    {
        Task<Tournament> CreateTournament(Tournament Tournament);
        Task<Tournament> GetTournament(int id);
        Task<List<Tournament>> GetTournaments();
        Task DeleteTournament(int id);
        Task EditTournament(Tournament Tournament);

    }
}
