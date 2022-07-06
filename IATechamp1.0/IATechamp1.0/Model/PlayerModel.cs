using Microsoft.EntityFrameworkCore;

namespace IATechamp1._0.Class
{
    public class PlayerModel
    {
        public PlayerModel()
        {
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
