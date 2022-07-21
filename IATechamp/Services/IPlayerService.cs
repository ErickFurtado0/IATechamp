using IATechamp.Models;

namespace IATechamp.Service
{
    public interface IPlayerService
    {
        Task<IList<PlayerModel>> GetNamePlayer(string namePlayer);
    }
}
