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
    public class TournamentController : Controller
    {
        private readonly ILogger<TournamentController> _logger;
        private readonly ITournamentService _TournamentService;

        public TournamentController(ILogger<TournamentController> logger, ITournamentService TournamentService)
        {
            _logger = logger;
            _TournamentService = TournamentService;
        }
        [HttpGet]
        public async Task<IActionResult> GetTournament()
        {
            var Tournaments = await _TournamentService.GetTournaments();
            return Ok(Tournaments);
        }
        [HttpPost]
        public async Task<Tournament> CreateTournament([FromBody] Tournament Tournament)
        {
            return await _TournamentService.CreateTournament(Tournament);             
        }
    }
}
