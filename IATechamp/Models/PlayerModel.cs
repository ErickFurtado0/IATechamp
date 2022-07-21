namespace IATechamp.Models
{
    public class PlayerModel
    {
        public PlayerModel()
        {
        }

        public PlayerModel(string namePlayer)
        {
            NamePlayer = namePlayer;
        }

        public PlayerModel(int idPlayer, string namePlayer)
        {
            IdPlayer = idPlayer;
            NamePlayer = namePlayer;
        }

        public int IdPlayer { get; set; }
        public string NamePlayer { get; set; }
    }
}
