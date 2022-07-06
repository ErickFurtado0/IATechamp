namespace IATechamp1._0.Class
{
    public class ScoreboardModel
    {
        public ScoreboardModel()
        {
        }

        public ScoreboardModel(int playerPoints, int setPoints)
        {
            PlayerPoints = playerPoints;
            SetPoints = setPoints;
        }

        public ScoreboardModel(int idScoreboard, int setPoints, int playerPoints, int gamePoints, int gamePlayed)
        {
            IdScoreboard = idScoreboard;
            SetPoints = setPoints;
            PlayerPoints = playerPoints;
            GamePoints = gamePoints;
            GamePlayed = gamePlayed;
        }

        public int IdScoreboard { get; set; }

        public int SetPoints { get; set; }

        public int PlayerPoints { get; set; }

        public int GamePoints { get; set; }

        public int GamePlayed { get; set; }

    }
}
