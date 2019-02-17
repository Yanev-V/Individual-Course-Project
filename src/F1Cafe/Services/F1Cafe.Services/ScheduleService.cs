using AutoMapper;
using F1Cafe.Common;
using F1Cafe.Common.Exceptions.Schedules;
using F1Cafe.Models.ViewModels.Schedules;
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
    public class ScheduleService : BaseService, IScheduleService
    {
        public ScheduleService(F1CafeDbContext dbContext, IMapper mapper)
            : base(dbContext, mapper)
        {
        }
        
        public async Task<ScheduleViewModel> GetRaceScheduleAsync(int id)
        {
            var schedule = await this.DbContext.Schedules
                .FirstOrDefaultAsync(r => r.Id == id);

            CoreValidator.ThrowIfNull(schedule, new InvalidScheduleException());

            var scheduleViewModel = this.Mapper.Map<ScheduleViewModel>(schedule);

            return scheduleViewModel;
        }
    }
}
