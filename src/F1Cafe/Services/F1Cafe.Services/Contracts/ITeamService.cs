using F1Cafe.Models.InputModels.Teams;
using F1Cafe.Models.ViewModels.Teams;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace F1Cafe.Services.Contracts
{
    public interface ITeamService
    {
        Task<int> CreateTeamAsync(CreateTeamInputModel inputModel);

        AllTeamsViewModel GetAllTeams();

        Task<TeamDetailsViewModel> GetTeamDetailsAsync(int id);
    }
}