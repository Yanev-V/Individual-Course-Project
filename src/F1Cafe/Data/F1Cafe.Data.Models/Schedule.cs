using F1Cafe.Data.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace F1Cafe.Data.Models
{
    public class Schedule : BaseModel<int>
    {
        public int RaceId { get; set; }
        public Race Race { get; set; }

        [Required]
        public DateTime Practice1Start { get; set; }

        [Required]
        public DateTime Practice2Start { get; set; }

        [Required]
        public DateTime Practice3Start { get; set; }

        [Required]
        public DateTime QualifyingStart { get; set; }

        [Required]
        public DateTime RaceStart { get; set; }
    }
}
