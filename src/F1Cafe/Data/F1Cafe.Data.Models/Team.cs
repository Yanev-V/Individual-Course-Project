using F1Cafe.Data.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace F1Cafe.Data.Models
{
    public class Team : BaseModel<int>
    {
        public Team()
        {
            this.Cars = new HashSet<Car>();
            this.Drivers = new HashSet<Driver>();
        }

        [Required]
        public string Name { get; set; }

        public string FullName { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required]
        public string Base { get; set; }

        [Required]
        public DateTime EntryYear { get; set; }

        [Required]
        public string TeamChief { get; set; }

        public string TeamLogo { get; set; }

        public ICollection<Car> Cars { get; set; }

        public ICollection<Driver> Drivers { get; set; }
    }
}
