using F1Cafe.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace F1Cafe.Data.Configurations
{
    public class RaceConfiguration : IEntityTypeConfiguration<Race>
    {
        public void Configure(EntityTypeBuilder<Race> builder)
        {
            builder
                 .HasMany(r => r.Drivers)
                 .WithOne(dr => dr.Race)
                 .HasForeignKey(dr => dr.DriverId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder
                 .HasMany(r => r.Orders)
                 .WithOne(o => o.Race)
                 .HasForeignKey(o => o.RaceId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
