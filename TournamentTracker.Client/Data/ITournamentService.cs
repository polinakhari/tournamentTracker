using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentTracker.Shared.Models;

namespace TournamentTracker.Client.Data
{
    public interface ITournamentService
    {
        Task<Tournament> CreateTournament(Tournament Tournament);
        Task<List<Tournament>> GetTournaments();
        Task EditTournament(Tournament Tournament);
    }
}
