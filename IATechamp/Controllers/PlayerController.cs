using IATechamp.Models;
using IATechamp.Service;
using Microsoft.AspNetCore.Mvc;

namespace IATechamp.Controllers
{
        [ApiController]
        [Route("")]
        public class PlayerController : ControllerBase
        {
            private readonly IPlayerService _playerService;

            public PlayerController(IPlayerService playerService)
            {
                _playerService = playerService;
            }

            [HttpPost]
            [Route("post-nameplayer")]
            public async Task<ActionResult<IList<PlayerModel>>> PostNamePlayer(string namePlayer)
            {
                var result = await _playerService.PostNamePlayer(namePlayer);
                return Ok(result);
            }

        [HttpPut]
            [Route("set-players-name")]
            public async Task<ActionResult<IList<PlayerModel>>> SetNamePlayer(string namePlayer)
            {
                var result = await _playerService.GetNamePlayer(namePlayer);
                return Ok(result);
            }

            [HttpGet]
            [Route("players-name")]
            public async Task<ActionResult<IList<PlayerModel>>> GetNamePlayer(string namePlayer)
            {
                var result = await _playerService.GetNamePlayer(namePlayer);
                return Ok(result);
            }
        }
    }
