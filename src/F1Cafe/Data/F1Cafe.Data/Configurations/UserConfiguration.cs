using F1Cafe.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace F1Cafe.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<F1CafeUser>
    {
        public void Configure(EntityTypeBuilder<F1CafeUser> builder)
        {
            builder
                 .HasMany(u => u.Orders)
                 .WithOne(o => o.Customer)
                 .HasForeignKey(o => o.CustomerId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder
                 .HasMany(u => u.News)
                 .WithOne(n => n.Author)
                 .HasForeignKey(n => n.AuthorId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder
                 .HasMany(u => u.Comments)
                 .WithOne(c => c.Author)
                 .HasForeignKey(c => c.AuthorId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
