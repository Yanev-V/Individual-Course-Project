using System;
using System.ComponentModel.DataAnnotations;

namespace F1Cafe.Models.InputModels.Teams
{
    public class CreateTeamInputModel
    {
        [Required]
        [Display(Name = "Team Name")]
        public string Name { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        public string Nationality { get; set; }

        [Required]
        public string Base { get; set; }

        [Required]
        [Display(Name = "Entry Year")]
        public int EntryYear { get; set; }

        [Required]
        [Display(Name = "Team Chief")]
        public string TeamChief { get; set; }

        [Required]
        [Display(Name = "Championship Titles")]
        public int ChampionshipTitles { get; set; }
    }
}
