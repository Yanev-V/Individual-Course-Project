using F1Cafe.Data.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace F1Cafe.Data.Models
{
    public class Order : BaseModel<int>
    {
        [Required]
        public DateTime OrderedOn { get; set; }

        public int RaceId { get; set; }
        [Required]
        public Race Race { get; set; }

        public string CustomerId { get; set; }
        [Required]
        public F1CafeUser Customer { get; set; }

        [Required]
        public int TicketsCount { get; set; }
    }
}
