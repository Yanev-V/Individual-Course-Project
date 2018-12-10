using F1Cafe.Data.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace F1Cafe.Data.Models
{
    public class Race : BaseModel<int>
    {
        public Race()
        {
            this.Drivers = new HashSet<DriversRaces>();

            this.Orders = new HashSet<Order>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Country { get; set; }

        public int TrackId { get; set; }
        [Required]
        public Track Track { get; set; }

        [Required]
        public int NumberOfLaps { get; set; }

        [Required]
        public decimal RaceDistance { get; set; }

        public int ScheduleId { get; set; }
        public Schedule Schedule { get; set; }

        [Required]
        public int TotalTickets { get; set; }

        public ICollection<DriversRaces> Drivers { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
