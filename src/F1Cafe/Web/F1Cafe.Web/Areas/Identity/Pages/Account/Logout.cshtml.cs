using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using F1Cafe.Services.Contracts;

namespace F1Cafe.Web.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LogoutModel : PageModel
    {
        private readonly IUserService userService;

        public LogoutModel(IUserService userService)
        {
            this.userService = userService;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(string returnUrl = null)
        {
            this.userService.Logout();
            
            if (returnUrl != null)
            {
                return LocalRedirect(returnUrl);
            }
            else
            {
                return Page();
            }
        }
    }
}