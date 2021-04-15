using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentTracker.BD;
using TournamentTracker.BD.Models;

namespace TournamentTracker.Server.Services
{
    
    public class TeamService : ITeamService
    {
        private readonly AppDbContext _context;
        public TeamService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Team> CreateTeam(Team Team)
        {
            _context.Teams.Add(Team);
             await _context.SaveChangesAsync();
            return Team;
        }

        public async Task DeleteTeam(int id)
        {
            Team deletedTeam = _context.Teams.First(x => x.Id == id);
            _context.Teams.Remove(deletedTeam);
            await _context.SaveChangesAsync();
        }

        public async Task EditTeam(Team Team)
        {
            Team editedTeam = _context.Teams.Find(Team.Id);
            editedTeam.TeamName = Team.TeamName;
            editedTeam.TournamentId = Team.TournamentId;
            await _context.SaveChangesAsync();
        }

        public async Task<Team> GetTeam(int id)
        {
            return await _context.Teams.FindAsync(id);
        }

        public async Task<List<Team>> GetTeams()
        {
            return _context.Teams.ToList();
        }
    }
}
