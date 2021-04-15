using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TournamentTracker.Shared.Models
{
    public class Matchup
    {
        public int Id { get; set; }
        public List<MatchupEntry> Entrys { get; set; } 
        public Team Winner { get; set; }
        public int WinnerId { get; set; }
        public int MatchupRound { get; set; }
    }
}
