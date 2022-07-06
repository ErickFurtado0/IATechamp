using IATechamp1._0.Class;
using IATechamp1._0.Service;
using Microsoft.AspNetCore.Mvc;

namespace IATechamp1._0.Controllers
{
    [ApiController]
    [Route("[api/players]")]
    public class PlayerController : ControllerBase
    {
        private readonly IPlayerService _playerService;

        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
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
