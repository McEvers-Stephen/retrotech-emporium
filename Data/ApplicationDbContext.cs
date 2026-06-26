using Microsoft.EntityFrameworkCore;
using RetrotechEmporium.Models;

namespace RetrotechEmporium.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Retro Gaming" },
                new Category { Id = 2, Name = "Retro Computers" },
                new Category { Id = 3, Name = "Modern Tech" },
                new Category { Id = 4, Name = "Audio" },
                new Category { Id = 5, Name = "Retro Tech" },
                new Category { Id = 6, Name = "Modern Computers" },
                new Category { Id = 7, Name = "Accessories" },
                new Category { Id = 8, Name = "Modern Gaming"}
                );

            modelBuilder.Entity<Product>().HasData(
        new Product
        {
            productId = 1,
            productName = "Nintendo Entertainment System",
            productPrice = 99.99m,
            yearReleased = 1985,
            quantityInStock = 5,
            categoryId = 1,
            productImage = "/images/nes.jpg",
            productDescription = "Classic 8-bit gaming console"
        },
        new Product
        {
            productId = 2,
            productName = "Commodore 64",
            productPrice = 149.99m,
            yearReleased = 1982,
            quantityInStock = 3,
            categoryId = 2,
            productImage = "/images/c64.jpg",
            productDescription = "Iconic home computer of the 80s"
        }
    );
        }
    
    }
}
