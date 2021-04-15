using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentTracker.BD;
using TournamentTracker.BD.Models;

namespace TournamentTracker.Server.Services
{
    
    public class MatchupService : IMatchupService
    {
        private readonly AppDbContext _context;
        public MatchupService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Matchup> CreateMatchup(Matchup matchup)
        {
            _context.Matchup.Add(matchup);
             await _context.SaveChangesAsync();
            return matchup;
        }

        public async void DeleteMatchup(int id)
        {
            Matchup deletedMatchup = _context.Matchup.First(x => x.Id == id);
            _context.Matchup.Remove(deletedMatchup);
            await _context.SaveChangesAsync();
        }

        public async void EditMatchup(Matchup matchup)
        {
            Matchup editedMatchup = _context.Matchup.Find(matchup.Id);
            editedMatchup.MatchupRound = matchup.MatchupRound;
            editedMatchup.WinnerId = matchup.WinnerId;
            await _context.SaveChangesAsync();
        }

        public async Task<Matchup> GetMatchup(int id)
        {
            return await _context.Matchup.FindAsync(id);
        }

        public async Task<List<Matchup>> GetMatchups()
        {
            return _context.Matchup.ToList();
        }
    }
}
