using F1Cafe.Models.ViewModels.Races;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace F1Cafe.Services.Contracts
{
    public interface IRaceService
    {
        AllRacesViewModel GetAllRaces();

        Task<RaceDetailsViewModel> GetRaceDetailsAsync(int id);
    }
}
