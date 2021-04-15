using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TournamentTracker.Shared.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public int TournamentId { get; set; }
        public List<Person> TeamMembers { get; set; } = new List<Person>();
    }
}
