using F1Cafe.Models.ViewModels.Tracks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace F1Cafe.Services.Contracts
{
    public interface ITrackService
    {
        Task<TrackDetailsViewModel> GetTrackDetailsAsync(int id, int lap);
    }
}
