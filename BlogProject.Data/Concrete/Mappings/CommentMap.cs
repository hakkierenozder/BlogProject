using BlogProject.Shared.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Data.Concrete.Mappings
{
    public class CommentMap : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Content).IsRequired();

            builder.HasOne<Post>(c => c.Post).WithMany(p => p.Comments).HasForeignKey(c => c.PostId);

            builder.ToTable("Comments");

            builder.HasData(new Comment
            {
                Id = 1,
                Title = "Yorum 1",
                Content = "Bemce em iyi film o değil",
                CreatedByName = "DerdoReyiz",
                PostId = 1,
                PublishedAt = DateTime.Now
            });
        }
    }
}
