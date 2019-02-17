using System;

namespace F1Cafe.Models.ViewModels.Races
{
    public class RaceViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string RaceWeekend
        {
            get
            {
                if (this.Start.Month == this.End.Month)
                {
                    return this.Start.ToString("dd") + " - " + this.End.ToString("dd MMM").ToUpper();
                }
                else
                {
                    return (this.Start.ToString("dd MMM") + " - " + this.End.ToString("dd MMM")).ToUpper();
                }
            }
        }
    }
}
