using AutoMapper;
using F1Cafe.Common;
using F1Cafe.Common.Exceptions;
using F1Cafe.Common.Exceptions.Drivers;
using F1Cafe.Common.Exceptions.Teams;
using F1Cafe.Data.Models;
using F1Cafe.Models.InputModels.Drivers;
using F1Cafe.Models.ViewModels.Drivers;
using F1Cafe.Services.Contracts;
using F1Cafe.Web.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Cafe.Services
{
    public class DriverService : BaseService, IDriverService
    {
        public DriverService(F1CafeDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }

        public async Task<int> CreateDriverAsync(CreateDriverInputModel inputModel)
        {
            if (this.DbContext.Drivers.Any(d => d.FirstName == inputModel.FirstName &&
                                                d.LastName == inputModel.LastName))
            {
                throw new DriverExistsException();
            }

            var driver = this.Mapper.Map<Driver>(inputModel);

            var statistics = new Statistics();
            await this.DbContext.Statistics.AddAsync(statistics);
            await this.DbContext.SaveChangesAsync();

            driver.Statistics = statistics;

            var team = await this.DbContext.Teams
                .FirstOrDefaultAsync(t => t.Name == inputModel.TeamName);

            CoreValidator.ThrowIfNull(team, new InvalidTeamException());

            driver.Team = team;

            try
            {
                await this.DbContext.Drivers.AddAsync(driver);
                await this.DbContext.SaveChangesAsync();
            }
            catch
            {
                throw new SaveDbChangesException();
            }            

            return driver.Id;
        }

        public AllDriversViewModel GetAllDrivers()
        {
            var allDrivers = this.DbContext.Drivers
                .Include(d => d.Team)
                .Select(d => this.Mapper.Map<DriverViewModel>(d));

            var allDriversViewModel = new AllDriversViewModel { Drivers = allDrivers };

            return allDriversViewModel;
        }
    }
}
