using F1Cafe.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace F1Cafe.Data.Configurations
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder
                 .HasMany(t => t.Drivers)
                 .WithOne(d => d.Team)
                 .HasForeignKey(t => t.TeamId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder
                 .HasMany(t => t.Cars)
                 .WithOne(c => c.Team)
                 .HasForeignKey(t => t.TeamId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
