using IATechamp1._0.Class;

namespace IATechamp1._0.Controllers
{
    public interface IScoreboardService
    {
        Task <IList<ScoreboardModel>> GetPlayersPoints(int playerPoints);
        Task <IList<ScoreboardModel>> GetSetsPoints(int setPoints);
    }
}