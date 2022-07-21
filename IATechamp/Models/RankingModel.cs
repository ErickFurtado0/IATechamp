using IATechamp.Intarfaces;

namespace IATechamp.Models
{
        public class RankingModel : ScoreboardModel, IRanking
    {
        public RankingModel(int playerPoints, int setPoints) : base(playerPoints, setPoints)
        {
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}

