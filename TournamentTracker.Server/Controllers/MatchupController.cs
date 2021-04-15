using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TournamentTracker.Server.Services;

namespace TournamentTracker.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MatchupController : Controller
    {
        private readonly ILogger<MatchupController> _logger;
        private readonly IMatchupService _matchupService;

        public MatchupController(ILogger<MatchupController> logger, IMatchupService matchupService)
        {
            _logger = logger;
            _matchupService = matchupService;
        }
        [HttpGet]
        public async Task<IActionResult> GetMatchup()
        {
            var matchups = await _matchupService.GetMatchups();
            return Ok(matchups);
        }
    }
}
