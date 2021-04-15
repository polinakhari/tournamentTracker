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
    public class PrizeController : Controller
    {
        private readonly ILogger<PrizeController> _logger;
        private readonly IPrizeService _PrizeService;

        public PrizeController(ILogger<PrizeController> logger, IPrizeService PrizeService)
        {
            _logger = logger;
            _PrizeService = PrizeService;
        }
        [HttpGet]
        public async Task<IActionResult> GetPrize()
        {
            var Prizes = await _PrizeService.GetPrizes();
            return Ok(Prizes);
        }
        [HttpPost]
        public async Task CreatePrize([FromBody] Prize prize)
        {
            await _PrizeService.CreatePrize(prize);
        }
    }
}
