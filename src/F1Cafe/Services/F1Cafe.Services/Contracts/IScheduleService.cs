using F1Cafe.Models.ViewModels.Schedules;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace F1Cafe.Services.Contracts
{
    public interface IScheduleService
    {
        Task<ScheduleViewModel> GetRaceScheduleAsync(int id);
    }
}
