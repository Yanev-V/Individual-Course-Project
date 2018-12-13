using AutoMapper;
using F1Cafe.Common;
using F1Cafe.Common.Exceptions;
using F1Cafe.Common.Exceptions.Teams;
using F1Cafe.Data.Models;
using F1Cafe.Models.InputModels.Teams;
using F1Cafe.Models.ViewModels.Teams;
using F1Cafe.Services.Contracts;
using F1Cafe.Web.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Cafe.Services
{
    public class TeamService : BaseService, ITeamService
    {
        private const string TeamLogoPath = "/images/teams/{0}_logo.jpg";

        public TeamService(F1CafeDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }

        public async Task<int> CreateTeamAsync(CreateTeamInputModel inputModel)
        {
            if (this.DbContext.Teams.Any(t => t.Name == inputModel.Name))
            {
                throw new TeamExistsException();
            }

            var team = this.Mapper.Map<Team>(inputModel);

            team.TeamLogo = string.Format(TeamLogoPath, team.Name);

            try
            {
                await this.DbContext.Teams.AddAsync(team);
                await this.DbContext.SaveChangesAsync();
            }
            catch
            {
                throw new SaveDbChangesException();
            }            

            return team.Id;
        }

        public AllTeamsViewModel GetAllTeams()
        {
            var dbTeams = this.DbContext.Teams
                .Include(t => t.Drivers);                

            var allTeams = dbTeams.Select(t => this.Mapper.Map<TeamViewModel>(t));

            var allTeamsViewModel = new AllTeamsViewModel { Teams = allTeams };

            return allTeamsViewModel;
        }
    }
}
