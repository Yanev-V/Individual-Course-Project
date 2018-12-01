using F1Cafe.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace F1Cafe.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
                 .HasOne(o => o.Customer)
                 .WithMany(c => c.Orders)
                 .HasForeignKey(o => o.CustomerId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder
                 .HasOne(o => o.Race)
                 .WithMany(r => r.Orders)
                 .HasForeignKey(o => o.RaceId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
