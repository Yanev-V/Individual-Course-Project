using System;
using System.ComponentModel.DataAnnotations;

namespace F1Cafe.Models.InputModels.Teams
{
    public class CreateTeamInputModel
    {
        [Required]
        [Display(Name = "Team name")]
        public string Name { get; set; }

        [Display(Name = "Full name")]
        public string FullName { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required]
        public string Base { get; set; }

        [Required]
        [Display(Name = "Entry year")]
        public DateTime EntryYear { get; set; }

        [Required]
        [Display(Name = "Team Chief")]
        public string TeamChief { get; set; }
    }
}
