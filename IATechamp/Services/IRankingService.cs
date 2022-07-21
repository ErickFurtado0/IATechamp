using IATechamp.Models;
using Microsoft.AspNetCore.Mvc;

namespace IATechamp.Services
{
    public interface IRankingService
    {
        Task<IList<RankingModel>> GetRankingName(string namePlayer, int playerPoints, int setPoints);
    }
}
