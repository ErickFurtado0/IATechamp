using IATechamp1._0.Class;
using Microsoft.AspNetCore.Mvc;

namespace IATechamp1._0.Controllers
{
    public class ScoreboardController : ControllerBase
    {
        private readonly IScoreboardService _scoreboardService;

        public ScoreboardController(IScoreboardService scoreboardService)
        {
            _scoreboardService = scoreboardService;
        }

        [HttpGet]
        [Route("player-points")]
        public async Task<ActionResult<IList<ScoreboardModel>>> GetPlayersPoints(int playerPoints)
        {
            var result = await _scoreboardService.GetPlayersPoints(playerPoints);
            return Ok(result);
        }

        [HttpGet]
        [Route("set-points")]
        public async Task<ActionResult<IList<ScoreboardModel>>> GetSetsPoints(int setPoints)
        {
            var result = await _scoreboardService.GetSetsPoints(setPoints);
            return Ok(result);
        }
    }
}
