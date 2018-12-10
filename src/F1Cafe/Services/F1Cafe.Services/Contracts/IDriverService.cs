using F1Cafe.Models.InputModels.Drivers;
using F1Cafe.Models.ViewModels.Drivers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace F1Cafe.Services.Contracts
{
    public interface IDriverService
    {
        Task<int> CreateDriverAsync(CreateDriverInputModel inputModel);

        AllDriversViewModel GetAllDrivers();
    }
}
