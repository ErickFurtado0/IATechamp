using IATechamp1._0.Class;
using System.Collections;

namespace IATechamp1._0.Service
{
    public interface IPlayerService
    {
        Task<IList<PlayerModel>> GetNamePlayer(string namePlayer);
    }
}