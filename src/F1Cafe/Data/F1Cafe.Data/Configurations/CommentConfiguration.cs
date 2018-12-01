using F1Cafe.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace F1Cafe.Data.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder
                 .HasOne(c => c.Author)
                 .WithMany(a => a.Comments)
                 .HasForeignKey(c => c.AuthorId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder
                 .HasOne(c => c.News)
                 .WithMany(n => n.Comments)
                 .HasForeignKey(c => c.NewsId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
