using F1Cafe.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1Cafe.Data.Models
{
    public class Car : BaseModel<int>
    {
        public int TeamId { get; set; }
        public Team Team { get; set; }

        public int DriverId { get; set; }
        public Driver Driver { get; set; }

        [Required]
        public string Chassis { get; set; }

        [Required]
        public string PowerUnit { get; set; }

        public string FrontImage { get; set; }

        public string SideImage { get; set; }

        public string TopImage { get; set; }

        [NotMapped]
        public int CarNumber { get; set; }
    }
}
