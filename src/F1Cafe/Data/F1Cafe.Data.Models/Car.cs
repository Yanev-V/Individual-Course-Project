﻿using F1Cafe.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace F1Cafe.Data.Models
{
    public class Car : BaseModel<int>
    {
        public int DriverId { get; set; }
        [Required]
        public Driver Driver { get; set; }

        [Required]
        public string Chassis { get; set; }

        [Required]
        public string PowerUnit { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public int CarNumber { get; set; }

        public int TeamId { get; set; }
        [Required]
        public Team Team { get; set; }
    }
}