using System;
using System.ComponentModel.DataAnnotations;

namespace F1Cafe.Models.InputModels.Drivers
{
    public class CreateDriverInputModel
    {
        [Required]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Birth date")]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        [Display(Name = "F1 Start year")]
        public DateTime F1StartYear { get; set; }

        [Required]
        [Display(Name = "Driver number")]
        public int DriverNumber { get; set; }

        [Required]
        [Display(Name = "Team name")]
        public string TeamName { get; set; }
    }
}
