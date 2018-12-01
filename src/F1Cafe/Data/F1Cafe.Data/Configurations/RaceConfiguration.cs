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
                 .WithOne(d => d.Race)
                 .HasForeignKey(r => r.DriverId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder
                 .HasOne(r => r.Schedule)
                 .WithOne(s => s.Race)
                 .HasForeignKey<Schedule>(c => c.RaceId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder
                 .HasOne(r => r.Track)
                 .WithOne(t => t.Race)
                 .HasForeignKey<Track>(c => c.RaceId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
