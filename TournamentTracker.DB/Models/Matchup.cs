using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TournamentTracker.BD.Models
{
    public class Matchup
    {
        [Key]
        public int Id { get; set; }
        public int WinnerId { get; set; }
        public int MatchupRound { get; set; }
    }
}
