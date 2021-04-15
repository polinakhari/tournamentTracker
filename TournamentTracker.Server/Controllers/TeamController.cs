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
    public class TeamController : Controller
    {
        private readonly ILogger<TeamController> _logger;
        private readonly ITeamService _TeamService;

        public TeamController(ILogger<TeamController> logger, ITeamService TeamService)
        {
            _logger = logger;
            _TeamService = TeamService;
        }
        [HttpGet]
        public async Task<IActionResult> GetTeam()
        {
            var Teams = await _TeamService.GetTeams();
            return Ok(Teams);
        }
        [HttpPost]
        public async Task<Team> CreateTeam([FromBody] Team Team)
        {
            return await _TeamService.CreateTeam(Team);             
        }
    }
}
