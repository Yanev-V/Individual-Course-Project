using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F1Cafe.Common;
using F1Cafe.Models.InputModels.Drivers;
using F1Cafe.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace F1Cafe.Web.Controllers
{
    public class DriversController : BaseController
    {
        private readonly IDriverService driverService;

        public DriversController(IDriverService driverService)
        {
            this.driverService = driverService;
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        [HttpPost]
        public async Task<IActionResult> Create(CreateDriverInputModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(inputModel);
            }

            var driverId = await this.driverService.CreateDriverAsync(inputModel);

            return View(); //TODO: Redirect to details
        }

        [HttpGet]
        public IActionResult All()
        {
            var allDriversViewModel = this.driverService.GetAllDrivers();

            return this.View(allDriversViewModel);
        }
    }
}