using Microsoft.AspNetCore.Mvc;
using F1Cafe.Common;

namespace F1Cafe.Web.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
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
