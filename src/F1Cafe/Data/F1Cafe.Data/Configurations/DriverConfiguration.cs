using F1Cafe.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace F1Cafe.Data.Configurations
{
    public class DriverConfiguration : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder
                 .HasMany(d => d.Races)
                 .WithOne(r => r.Driver)
                 .HasForeignKey(d => d.DriverId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder
                 .HasOne(d => d.Statistics)
                 .WithOne(s => s.Driver)
                 .HasForeignKey<Statistics>(d => d.DriverId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder
                 .HasOne(d => d.Car)
                 .WithOne(c => c.Driver)
                 .HasForeignKey<Car>(c => c.DriverId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder
                 .HasOne(d => d.Team)
                 .WithMany(t => t.Drivers)
                 .HasForeignKey(d => d.TeamId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
