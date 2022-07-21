namespace IATechamp.Models
{
    public class ChampionshipModel
    {
        public ChampionshipModel()
        {
        }

        public ChampionshipModel(int idChampionship, string? nameChampionship)
        {
            IdChampionship = idChampionship;
            NameChampionship = nameChampionship;
        }

        public int IdChampionship { get; set; }

        public string? NameChampionship { get; set; }

    }
}
