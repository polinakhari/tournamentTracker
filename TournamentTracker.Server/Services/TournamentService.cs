using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentTracker.BD;
using TournamentTracker.BD.Models;

namespace TournamentTracker.Server.Services
{
    
    public class TournamentService : ITournamentService
    {
        private readonly AppDbContext _context;
        public TournamentService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Tournament> CreateTournament(Tournament Tournament)
        {
            _context.Tournaments.Add(Tournament);
             await _context.SaveChangesAsync();
            return Tournament;
        }

        public async Task DeleteTournament(int id)
        {
            Tournament deletedTournament = _context.Tournaments.First(x => x.Id == id);
            _context.Tournaments.Remove(deletedTournament);
            await _context.SaveChangesAsync();
        }

        public async Task EditTournament(Tournament Tournament)
        {
            Tournament editedTournament = _context.Tournaments.Find(Tournament.Id);
            editedTournament.TournamentName = Tournament.TournamentName;
            editedTournament.EntryFee = Tournament.EntryFee;
            await _context.SaveChangesAsync();
        }

        public async Task<Tournament> GetTournament(int id)
        {
            return await _context.Tournaments.FindAsync(id);
        }

        public async Task<List<Tournament>> GetTournaments()
        {
            return _context.Tournaments.ToList();
        }
    }
}
