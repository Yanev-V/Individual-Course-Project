using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using F1Cafe.Common;
using F1Cafe.Models.InputModels.Teams;
using F1Cafe.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace F1Cafe.Web.Controllers
{    
    public class TeamsController : BaseController
    {
        private readonly ITeamService teamService;

        public TeamsController(ITeamService teamService)
        {
            this.teamService = teamService;
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
        [HttpPost]
        public async Task<IActionResult> Create(CreateTeamInputModel inputModel)
        {
            if (!this.ModelState.IsValid)
            {
                return View(inputModel);
            }

            var teamId = await this.teamService.CreateTeamAsync(inputModel);

            return this.RedirectToAction(nameof(Details), new { id = teamId });
        }

        [HttpGet]
        public IActionResult All()
        {
            var allTeamsViewModel = this.teamService.GetAllTeams();

            return this.View(allTeamsViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var teamDetailsViewModel = await this.teamService.GetTeamDetailsAsync(id);

            return this.View(teamDetailsViewModel);
        }
    }
}