using EntityFramework.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Configuration
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Content).IsRequired();
            builder.HasOne(x => x.User)
                   .WithMany(x => x.Posts)
                   .HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Category)
                   .WithMany(x => x.posts)
                   .HasForeignKey(x=>x.CategoryId);

        }
    }
}
