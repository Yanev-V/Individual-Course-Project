namespace F1Cafe.Models.ViewModels.Races
{
    public class RaceDetailsViewModel : RaceViewModel
    {
        public string Country { get; set; }

        public int NumberOfLaps { get; set; }

        public int ScheduleId { get; set; }

        public int TrackId { get; set; }
    }
}
