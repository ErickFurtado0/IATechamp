using IATechamp.Models;

namespace IATechamp.Services
{
    public interface IScoreboardService
    {
        Task<IList<ScoreboardModel>> GetPlayersPoints(int playerPoints);
        Task<IList<ScoreboardModel>> GetSetsPoints(int setPoints);
        Task<IList<ScoreboardModel>> GetGamesPoints(int gamePoints);
    }
}
