using System;
using System.ComponentModel.DataAnnotations;

namespace F1Cafe.Data.Models
{
    public class DriversRaces
    {
        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        public int RaceId { get; set; }
        public Race Race { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [Required]
        public int Position { get; set; }

        [Required]
        public int RacePoints { get; set; }

        [Required]
        public int Laps { get; set; }
    }
}
