using F1Cafe.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace F1Cafe.Models.ViewModels.Teams
{
    public class TeamViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string TeamLogo { get; set; }

        public ICollection<Driver> Drivers { get; set; }

        public string FirstDriverName => this.Drivers.ToArray()[this.Drivers.Count() - 1].FirstName + ' '
            + this.Drivers.ToArray()[this.Drivers.Count() - 1].LastName;

        public string SecondDriverName => this.Drivers.ToArray()[this.Drivers.Count() - 2].FirstName + ' '
            + this.Drivers.ToArray()[this.Drivers.Count() - 2].LastName;
    }
}
