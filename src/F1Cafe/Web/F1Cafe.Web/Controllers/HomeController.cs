using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using F1Cafe.Common;

namespace F1Cafe.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
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
