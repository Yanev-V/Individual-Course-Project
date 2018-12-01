using F1Cafe.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace F1Cafe.Data.Models
{
    public class Statistics : BaseModel<int>
    {
        public int Participations { get; set; }

        public int WorldChampionships { get; set; }

        public int Podiums { get; set; }

        public int TotalPoints { get; set; }

        public int CurrentSeasonPoints { get; set; }

        public int DriverId { get; set; }
        [Required]
        public Driver Driver { get; set; }
    }
}
