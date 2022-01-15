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
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.Property(p => p.Title).IsRequired();
            builder.Property(p => p.Content).IsRequired();

            builder.Property(p => p.CreatedAt).IsRequired();

            builder.HasOne<Category>(p => p.Category).WithMany(c => c.Posts).HasForeignKey(p => p.CategoryId);
            builder.HasOne<User>(p=>p.User).WithMany(u=>u.Posts).HasForeignKey(p=>p.UserId);

            builder.ToTable("Posts");

            builder.HasData(new Post
            {
                Id = 1,
                Title = "2021 yılının En İyi Filmleri",
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin vitae molestie mi, id tincidunt ex. Phasellus cursus condimentum tempus. Ut et blandit ligula, a ultrices.",
                CategoryId = 1,
                UserId = 1,
               
            });
        }
    }
}
