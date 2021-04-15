using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TournamentTracker.Shared.Models
{
    public class MatchupEntry
    {
        public int Id { get; set; }
        public Team TeamCompeting { get; set; }
        public int TeamCompetingId { get; set; }
        public double Score { get; set; }
        public Matchup ParentMatchup { get; set; }
        public int ParentMatchupId { get; set; }
    }
}
