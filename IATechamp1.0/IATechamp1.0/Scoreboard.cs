namespace IATechamp1._0
{
    public class Scoreboard
    {
        public int IdScoreboard { get; set; }

        public int SetPoints { get; set; }

        public int PlayerPoints { get; set; }

        public int GamePoints { get; set; }

        public Scoreboard(int setPoints, int playerPoints, int gamePoints)
        {
            SetPoints = setPoints;
            GamePoints = gamePoints;
            PlayerPoints = playerPoints;
        }
    }
}
