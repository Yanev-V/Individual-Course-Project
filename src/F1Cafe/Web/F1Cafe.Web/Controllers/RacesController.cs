using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F1Cafe.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace F1Cafe.Web.Controllers
{
    public class RacesController : BaseController
    {
        private readonly IRaceService raceService;

        public RacesController(IRaceService raceService)
        {
            this.raceService = raceService;
        }

        [HttpGet]
        public IActionResult All()
        {
            return this.View();
        }
    }
}