using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentTracker.BD.Models;

namespace TournamentTracker.Server.Services
{
    public interface IPrizeService
    {
        Task<Prize> CreatePrize(Prize prize);
        Task<Prize> GetPrize(int id);
        Task<List<Prize>> GetPrizes();
        Task DeletePrize(int id);
        Task EditPrize(Prize prize);

    }
}
