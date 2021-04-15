using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentTracker.BD;
using TournamentTracker.BD.Models;

namespace TournamentTracker.Server.Services
{
    
    public class MemberService : IMemberService
    {
        private readonly AppDbContext _context;
        public MemberService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Person> CreateMember(Person member)
        {
            _context.Persons.Add(member);
             await _context.SaveChangesAsync();
            return member;
        }

        public async Task DeleteMember(int id)
        {
            Person deletedMember = _context.Persons.First(x => x.Id == id);
            _context.Persons.Remove(deletedMember);
            await _context.SaveChangesAsync();
        }

        public async Task EditMember(Person member)
        {
            Person editedMember = _context.Persons.Find(member.Id);
            editedMember.TeamId = member.TeamId;
            await _context.SaveChangesAsync();
        }

        public async Task<Person> GetMember(int id)
        {
            return await _context.Persons.FindAsync(id);
        }

        public async Task<List<Person>> GetMembers()
        {
            return _context.Persons.ToList();
        }
    }
}
