using IATechamp.Models;
using IATechamp.Services;
using Microsoft.AspNetCore.Mvc;

namespace IATechamp.Controllers
{
    [ApiController]
    [Route("")]
    public class ScoreboardController : ControllerBase
    {
        private readonly IScoreboardService _scoreboardService;

        public ScoreboardController(IScoreboardService scoreboardService)
        {
            _scoreboardService = scoreboardService;
        }

        [HttpPost]
        [Route("add-player-points")]
        public async Task<ActionResult<IList<ScoreboardModel>>> SetPlayersPoints(int playerPoints)
        {
            var result = await _scoreboardService.GetPlayersPoints(playerPoints);
            return Ok(result);
        }

        [HttpPost]
        [Route("add-set-points")]
        public async Task<ActionResult<IList<ScoreboardModel>>> SetSetsPoints(int setPoints)
        {
            var result = await _scoreboardService.GetSetsPoints(setPoints);
            return Ok(result);
        }

        [HttpPost]
        [Route("add-game-points")]
        public async Task<ActionResult<IList<ScoreboardModel>>> SetGamesPoints(int gamePoints)
        {
            var result = await _scoreboardService.GetGamesPoints(gamePoints);
            return Ok(result);
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

        [HttpGet]
        [Route("game-points")]
        public async Task<ActionResult<IList<ScoreboardModel>>> GetGamesPoints (int gamePoints)
        {
            var result = await _scoreboardService.GetGamesPoints(gamePoints);
            return Ok(result);
        }
    }
}
