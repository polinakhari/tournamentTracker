using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TournamentTracker.BD.Models;

namespace TournamentTracker.BD
{
    public class AppDbContext : DbContext
    {
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Prize> Prizes { get; set; }
        public DbSet<MatchupEntry> MatchupEntries { get; set; }
        public DbSet<Matchup> Matchup { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=Tournament;Integrated Security=True");
        }
    }

}
