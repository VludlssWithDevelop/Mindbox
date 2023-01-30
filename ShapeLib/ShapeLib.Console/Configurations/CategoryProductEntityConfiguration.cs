using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShapeLib.Console.Entities;

namespace ShapeLib.Console.Configurations
{
    public class CategoryProductEntityConfiguration : IEntityTypeConfiguration<CategoryProductEntity>
    {
        public void Configure(EntityTypeBuilder<CategoryProductEntity> builder)
        {
            builder.HasKey(categoryProductEntity => new { categoryProductEntity.ProductId, categoryProductEntity.CategoryId });

            builder.HasOne(categoryProductEntity => categoryProductEntity.Product)
                .WithMany(productEntity => productEntity.Categories)
                .HasForeignKey(categoryProductEntity => categoryProductEntity.ProductId);

            builder.HasOne(categoryProductEntity => categoryProductEntity.Category)
                .WithMany(categoryEntity => categoryEntity.Products)
                .HasForeignKey(categoryProductEntity => categoryProductEntity.ProductId);
        }
    }
}
