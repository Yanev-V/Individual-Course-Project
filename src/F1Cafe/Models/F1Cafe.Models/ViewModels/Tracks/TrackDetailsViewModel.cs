namespace F1Cafe.Models.ViewModels.Tracks
{
    public class TrackDetailsViewModel
    {
        public string Name { get; set; }

        public decimal CircuitLength { get; set; }

        public string TrackRecord { get; set; }

        public string ImageUrl { get; set; }

        public int NumberOfLaps { get; set; }

        public decimal RaceDistance => this.CircuitLength * this.NumberOfLaps;
    }
}
