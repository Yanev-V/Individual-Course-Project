using AutoMapper;
using F1Cafe.Common;
using F1Cafe.Common.Exceptions.Races;
using F1Cafe.Models.ViewModels.Races;
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
    public class RaceService : BaseService, IRaceService
    {
        public RaceService(F1CafeDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }

        public AllRacesViewModel GetAllRaces()
        {
            var dbRaces = this.DbContext.Races
                .Include(r => r.Schedule)
                .Where(r => r.Schedule.RaceStart.Year == DateTime.UtcNow.Year)
                .ToList();

            var allRaces = dbRaces.Select(r => this.Mapper.Map<RaceViewModel>(r));

            var allRacesViewModel = new AllRacesViewModel { Races = allRaces };

            return allRacesViewModel;
        }

        public async Task<RaceDetailsViewModel> GetRaceDetailsAsync(int id)
        {
            var race = await this.DbContext.Races
                .Include(r => r.Schedule)
                .Include(r => r.Track)
                .FirstOrDefaultAsync(r => r.Id == id);

            CoreValidator.ThrowIfNull(race, new InvalidRaceException());

            var raceDetailsViewModel = this.Mapper.Map<RaceDetailsViewModel>(race);

            return raceDetailsViewModel;
        }
    }
}
