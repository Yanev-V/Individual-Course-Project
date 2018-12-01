using F1Cafe.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace F1Cafe.Data.Configurations
{
    public class StatisticsConfiguration : IEntityTypeConfiguration<Statistics>
    {
        public void Configure(EntityTypeBuilder<Statistics> builder)
        {
            builder
                 .HasOne(s => s.Driver)
                 .WithOne(d => d.Statistics)
                 .HasForeignKey<Driver>(d => d.StatisticsId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
