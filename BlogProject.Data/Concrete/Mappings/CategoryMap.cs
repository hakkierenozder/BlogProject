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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.Title).IsRequired();
            builder.Property(c => c.Content).IsRequired();

            builder.ToTable("Categories");

            builder.HasData(new Category
            {

                Id = 1,
                Title = "Sinema",
                Content = "Sinema kategorisine ait İçerik"

            });
        }
    }
}
