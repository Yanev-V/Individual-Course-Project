using F1Cafe.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace F1Cafe.Data.Models
{
    public class Driver : BaseModel<int>
    {
        public Driver()
        {
            this.Results = new HashSet<Result>();
            this.Races = new HashSet<DriversRaces>();
        }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public DateTime F1StartYear { get; set; }

        public int TeamId { get; set; }
        [Required]
        public Team Team { get; set; }

        public int CarId { get; set; }
        [Required]
        public Car Car { get; set; }

        [Required]
        public int DriverNumber { get; set; }

        public int StatisticsId { get; set; }
        public Statistics Statistics { get; set; }

        public ICollection<Result> Results { get; set; }

        public ICollection<DriversRaces> Races { get; set; }
    }
}
