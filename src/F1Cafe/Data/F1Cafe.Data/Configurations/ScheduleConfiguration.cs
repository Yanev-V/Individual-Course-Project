using F1Cafe.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace F1Cafe.Data.Configurations
{
    public class ScheduleConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder
                 .HasOne(s => s.Race)
                 .WithOne(r => r.Schedule)
                 .HasForeignKey<Race>(d => d.ScheduleId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
