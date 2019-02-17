using System.Collections.Generic;

namespace F1Cafe.Models.ViewModels.Races
{
    public class AllRacesViewModel
    {
        public IEnumerable<RaceViewModel> Races { get; set; }
    }
}
