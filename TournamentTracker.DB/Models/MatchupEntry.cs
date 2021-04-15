using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TournamentTracker.BD.Models
{
    public class MatchupEntry
    {
        [Key]
        public int Id { get; set; }
        public int TeamCompetingId { get; set; }
        public double Score { get; set; }
        public int ParentMatchupId { get; set; }
    }
}
