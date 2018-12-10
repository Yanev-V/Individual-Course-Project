using System;
using System.Collections.Generic;
using System.Text;

namespace F1Cafe.Models.ViewModels.Drivers
{
    public class AllDriversViewModel
    {
        public IEnumerable<DriverViewModel> Drivers { get; set; }
    }
}
