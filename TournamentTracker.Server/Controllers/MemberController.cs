using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentTracker.BD.Models;
using TournamentTracker.Server.Services;

namespace TournamentTracker.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController : Controller
    {
        private readonly ILogger<MemberController> _logger;
        private readonly IMemberService _MemberService;

        public MemberController(ILogger<MemberController> logger, IMemberService MemberService)
        {
            _logger = logger;
            _MemberService = MemberService;
        }
        [HttpGet]
        public async Task<IActionResult> GetMember()
        {
            var members = await _MemberService.GetMembers();
            return Ok(members);
        }
        [HttpPost]
        public async Task CreateMember([FromBody] Person member)
        {
            await _MemberService.CreateMember(member);
        }
        [HttpPost("/edit")]
        public async Task EditMember([FromBody] Person member)
        {
            await _MemberService.EditMember(member);
        }
    }
}
