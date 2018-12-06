using System.ComponentModel.DataAnnotations;

namespace F1Cafe.Models.InputModels.Account
{
    public class RegisterInputModel
    {
        [Required]
        [RegularExpression("[a-zA-Z0-9-_.*~]{3,}", ErrorMessage = "The {0} should be at least 3 symbols long and" +
            " may only contain: (a-z A-Z 0-9 - _ . * ~)")]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 4)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
