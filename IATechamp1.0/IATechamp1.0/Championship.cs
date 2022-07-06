namespace IATechamp1._0
{
    public class Championship
    {
        public int IdChampionship { get; set; }

        public string? NameChampionship { get; set; }

        public Championship(string? nameChampionship)
        {
            NameChampionship = nameChampionship;
        }
    }
}
