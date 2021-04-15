using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentTracker.Shared.Models;

namespace TournamentTracker.Client.Data
{
    public interface IPrizeService
    {
        void CreatePrize(Prize prize);
    }
}
