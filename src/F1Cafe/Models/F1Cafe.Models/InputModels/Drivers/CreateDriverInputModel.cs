using System;
using System.ComponentModel.DataAnnotations;

namespace F1Cafe.Models.InputModels.Drivers
{
    public class CreateDriverInputModel
    {
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Birth Date")]
        public DateTime BirthDate { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        [Display(Name = "F1 Start Year")]
        public int F1StartYear { get; set; }

        [Required]
        [Display(Name = "Driver Number")]
        public int DriverNumber { get; set; }

        [Required]
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }
    }
}
