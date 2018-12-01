using F1Cafe.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace F1Cafe.Data.Configurations
{
    public class ResultConfiguration : IEntityTypeConfiguration<Result>
    {
        public void Configure(EntityTypeBuilder<Result> builder)
        {
            builder
                 .HasOne(r => r.Driver)
                 .WithMany(d => d.Results)
                 .HasForeignKey(r => r.DriverId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
