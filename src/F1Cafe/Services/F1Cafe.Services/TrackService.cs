using AutoMapper;
using F1Cafe.Common;
using F1Cafe.Common.Exceptions.Races;
using F1Cafe.Common.Exceptions.Tracks;
using F1Cafe.Models.ViewModels.Tracks;
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
    public class TrackService : BaseService, ITrackService
    {
        public TrackService(F1CafeDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }

        public async Task<TrackDetailsViewModel> GetTrackDetailsAsync(int id, int laps)
        {
            var track = await this.DbContext.Tracks
                .FirstOrDefaultAsync(t => t.Id == id);

            CoreValidator.ThrowIfNull(track, new InvalidTrackException());

            var trackDetailsViewModel = this.Mapper.Map<TrackDetailsViewModel>(track);
            trackDetailsViewModel.NumberOfLaps = laps;

            return trackDetailsViewModel;
        }
    }
}
