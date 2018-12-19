using F1Cafe.Data.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace F1Cafe.Data.Models
{
    public class Track : BaseModel<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal CircuitLength { get; set; }

        [Required]
        public DateTime TrackRecord { get; set; }

        public string ImageUrl { get; set; }
    }
}
