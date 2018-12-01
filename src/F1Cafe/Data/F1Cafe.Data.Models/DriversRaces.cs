namespace F1Cafe.Data.Models
{
    public class DriversRaces
    {
        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        public int RaceId { get; set; }
        public Race Race { get; set; }
    }
}
