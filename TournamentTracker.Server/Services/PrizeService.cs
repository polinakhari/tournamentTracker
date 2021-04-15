using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentTracker.BD;
using TournamentTracker.BD.Models;

namespace TournamentTracker.Server.Services
{
    
    public class PrizeService : IPrizeService
    {
        private readonly AppDbContext _context;
        public PrizeService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Prize> CreatePrize(Prize Prize)
        {
            _context.Prizes.Add(Prize);
             await _context.SaveChangesAsync();
            return Prize;
        }

        public async Task DeletePrize(int id)
        {
            Prize deletedPrize = _context.Prizes.First(x => x.Id == id);
            _context.Prizes.Remove(deletedPrize);
            await _context.SaveChangesAsync();
        }

        public async Task EditPrize(Prize Prize)
        {
            Prize editedPrize = _context.Prizes.Find(Prize.Id);
            editedPrize.PrizeAmount = Prize.PrizeAmount;
            await _context.SaveChangesAsync();
        }

        public async Task<Prize> GetPrize(int id)
        {
            return await _context.Prizes.FindAsync(id);
        }

        public async Task<List<Prize>> GetPrizes()
        {
            return _context.Prizes.ToList();
        }
    }
}
