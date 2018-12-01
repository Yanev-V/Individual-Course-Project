using F1Cafe.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace F1Cafe.Data.Configurations
{
    public class DriversRacesConfiguration : IEntityTypeConfiguration<DriversRaces>
    {
        public void Configure(EntityTypeBuilder<DriversRaces> builder)
        {
            builder
                 .HasKey(x => new { x.DriverId, x.RaceId });
        }
    }
}
