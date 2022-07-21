using IATechamp.Models;
using IATechamp.Services;
using Microsoft.AspNetCore.Mvc;

namespace IATechamp.Controllers
{

        [ApiController]
        [Route("")]
    public class RankingController : ControllerBase
    {
        private readonly IRankingService _rankingService;

        public RankingController(IRankingService rankingService)
        {
            _rankingService = rankingService;
        }

        [HttpGet]
        [Route("ranking")]
        public async Task<ActionResult<IList<RankingModel>>> GetRankingName(string namePlayer, int playerPoints, int setPoints)
        {
            var result = await _rankingService.GetRankingName(namePlayer, playerPoints, setPoints);
            return Ok(result);
        }
    }
}
