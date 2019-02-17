using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F1Cafe.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace F1Cafe.Web.Controllers
{
    public class SchedulesController : BaseController
    {
        private readonly IScheduleService scheduleService;

        public SchedulesController(IScheduleService scheduleService)
        {
            this.scheduleService = scheduleService;
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var scheduleViewModel = await this.scheduleService.GetRaceScheduleAsync(id);

            return this.PartialView("_RaceSchedule", scheduleViewModel);
        }
    }
}