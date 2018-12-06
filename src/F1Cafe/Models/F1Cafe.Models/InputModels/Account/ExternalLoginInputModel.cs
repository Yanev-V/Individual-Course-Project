using System.ComponentModel.DataAnnotations;

namespace F1Cafe.Models.InputModels.Account
{
    public class ExternalLoginInputModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
