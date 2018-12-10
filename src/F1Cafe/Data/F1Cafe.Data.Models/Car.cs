using F1Cafe.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace F1Cafe.Data.Models
{
    public class Car : BaseModel<int>
    {
        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        [Required]
        public string Chassis { get; set; }

        [Required]
        public string PowerUnit { get; set; }

        public string FrontImage { get; set; }

        public string SideImage { get; set; }

        public string RearImage { get; set; }

        public int? CarNumber => this.Driver.DriverNumber;

        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
