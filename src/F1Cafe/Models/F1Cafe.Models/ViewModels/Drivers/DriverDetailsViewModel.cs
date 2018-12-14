namespace F1Cafe.Models.ViewModels.Drivers
{
    public class DriverDetailsViewModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string BirthDate { get; set; }

        public string ImageUrl { get; set; }

        public string Country { get; set; }

        public int F1StartYear { get; set; }        

        public int DriverNumber { get; set; }

        public string TeamName { get; set; }

        public StatisticsDto Statistics { get; set; }
    }
}
