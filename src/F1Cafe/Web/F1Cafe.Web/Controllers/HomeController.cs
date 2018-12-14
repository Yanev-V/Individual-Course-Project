using Microsoft.AspNetCore.Mvc;
using F1Cafe.Common;

namespace F1Cafe.Web.Controllers
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            string message = this.TempData.ContainsKey(GlobalConstants.ErrorMessage)
                ? this.TempData[GlobalConstants.ErrorMessage].ToString() : null;

            this.ViewData[GlobalConstants.ErrorMessage] = string.IsNullOrWhiteSpace(message)
                ? GlobalConstants.UnhandledErrorMessage : message;

            return View();
        }
    }
}
