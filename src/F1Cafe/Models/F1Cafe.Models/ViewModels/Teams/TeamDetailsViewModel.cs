using F1Cafe.Models.ViewModels.Drivers;

namespace F1Cafe.Models.ViewModels.Teams
{
    public class TeamDetailsViewModel
    {
        public string Name { get; set; }

        public string FullName { get; set; }

        public string Nationality { get; set; }

        public string Base { get; set; }

        public int EntryYear { get; set; }

        public string TeamChief { get; set; }

        public int ChampionshipTitles { get; set; }

        public string TeamLogo { get; set; }

        public DriverViewModel FirstDriver { get; set; }

        public DriverViewModel SecondDriver { get; set; }

        public CarDto Car { get; set; }
    }
}
