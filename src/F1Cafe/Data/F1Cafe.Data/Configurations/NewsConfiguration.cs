using F1Cafe.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace F1Cafe.Data.Configurations
{
    public class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder
                 .HasMany(n => n.Comments)
                 .WithOne(c => c.News)
                 .HasForeignKey(c => c.NewsId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder
                 .HasOne(n => n.Author)
                 .WithMany(a => a.News)
                 .HasForeignKey(n => n.AuthorId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
