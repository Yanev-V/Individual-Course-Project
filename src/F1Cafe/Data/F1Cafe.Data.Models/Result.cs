using F1Cafe.Data.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace F1Cafe.Data.Models
{
    public class Result : BaseModel<int>
    {
        public int DriverId { get; set; }
        [Required]
        public Driver Driver { get; set; }

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
