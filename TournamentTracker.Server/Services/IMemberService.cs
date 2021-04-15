using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentTracker.BD.Models;

namespace TournamentTracker.Server.Services
{
    public interface IMemberService
    {
        Task<Person> CreateMember(Person member);
        Task<Person> GetMember(int id);
        Task<List<Person>> GetMembers();
        Task DeleteMember(int id);
        Task EditMember(Person person);

    }
}
