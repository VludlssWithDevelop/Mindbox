using Microsoft.EntityFrameworkCore;
using ShapeLib.Console.Configurations;
using ShapeLib.Console.Entities;

namespace ShapeLib.Console
{
    public class ProductsDbContext : DbContext
    {
        /// <summary>
        /// Продукты
        /// </summary>
        public DbSet<ProductEntity> Products { get; set; }
        /// <summary>
        /// Категории
        /// </summary>
        public DbSet<CategoryEntity> Categories { get; set; }
        /// <summary>
        /// Категории-Продукты
        /// </summary>
        public DbSet<CategoryProductEntity> CategoryProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductEntityConfiguration).Assembly);
        }

        /// <summary>
        /// Создать дефолтные записи в базе для SQL запроса
        /// </summary>
        public void SeedDefaultData()
        {
            if (!Categories.Any())
            {
                var categoryEntities = new List<CategoryEntity>()
                {
                    new CategoryEntity
                    {
                        Id = 1,
                        Name = "Мучные изделия"
                    },
                    new CategoryEntity
                    {
                        Id = 2,
                        Name = "Еда быстрого приготовления"
                    },
                    new CategoryEntity
                    {
                        Id = 3,
                        Name = "Молочное"
                    },
                    new CategoryEntity
                    {
                        Id = 4,
                        Name = "Жидкости"
                    },
                    new CategoryEntity
                    {
                        Id = 5,
                        Name = "Холодные напитки"
                    }
                };

                Categories.AddRange(categoryEntities);
                SaveChanges();
            }

            if (!Products.Any())
            {
                var productEntities = new List<ProductEntity>()
                {
                    new ProductEntity
                    {
                        Id = 1,
                        Name = "Колбаса"
                    },
                    new ProductEntity
                    {
                        Id = 2,
                        Name = "Молоко"
                    },
                    new ProductEntity
                    {
                        Id = 3,
                        Name = "Вода"
                    },
                    new ProductEntity
                    {
                        Id = 4,
                        Name = "Доширак"
                    }
                };

                Products.AddRange(productEntities);
                SaveChanges();
            }

            if (!CategoryProducts.Any())
            {
                var categoryProductEntities = new List<CategoryProductEntity>()
                {
                    new CategoryProductEntity
                    {
                        ProductId = 2,
                        CategoryId = 3
                    },
                    new CategoryProductEntity
                    {
                        ProductId = 2,
                        CategoryId = 4
                    },
                    new CategoryProductEntity
                    {
                        ProductId = 2,
                        CategoryId = 5
                    },
                    new CategoryProductEntity
                    {
                        ProductId = 3,
                        CategoryId = 4
                    },
                    new CategoryProductEntity
                    {
                        ProductId = 3,
                        CategoryId = 5
                    },
                    new CategoryProductEntity
                    {
                        ProductId = 4,
                        CategoryId = 2
                    }
                };

                CategoryProducts.AddRange(categoryProductEntities);
                SaveChanges();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\;Database=Products;Trusted_Connection=True");
        }
    }
}
