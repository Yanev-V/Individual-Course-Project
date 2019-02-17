using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F1Cafe.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace F1Cafe.Web.Controllers
{
    public class TracksController : Controller
    {
        private readonly ITrackService trackService;

        public TracksController(ITrackService trackService)
        {
            this.trackService = trackService;
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id, int laps)
        {
            var trackDetailsViewModel = await this.trackService.GetTrackDetailsAsync(id, laps);

            return this.PartialView("_TrackDetails", trackDetailsViewModel);
        }
    }
}