using F1Cafe.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace F1Cafe.Data.Configurations
{
    public class TrackConfiguration : IEntityTypeConfiguration<Track>
    {
        public void Configure(EntityTypeBuilder<Track> builder)
        {
            builder
                 .HasOne(t => t.Race)
                 .WithOne(r => r.Track)
                 .HasForeignKey<Race>(d => d.TrackId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
