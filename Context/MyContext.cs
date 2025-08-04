using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using Project.Models;

namespace Project.Context
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-UMBKH4R;Database=_NETITIProject;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var categories = new List<Category>()
            {
                new Category { CategoryId = 1, Name = "Electronics", Description = "Electronic devices and gadgets" },
                new Category { CategoryId = 2, Name = "Books", Description = "Various genres of books" },
                new Category { CategoryId = 3, Name = "Clothing", Description = "Apparel and accessories" },
                new Category { CategoryId = 4, Name = "Home", Description = "Home appliances and furniture" },
                new Category { CategoryId = 5, Name = "Sports", Description = "Sporting goods and equipment" }
            };

            var products = new List<Product>()
            {
                new Product { ProductId = 1, Title = "Smartphone", Price = 499.99m, Description = "Latest model smartphone", Quantity = 10, ImagePath = "images/smartphone.jpg", CategoryId = 1 },
                new Product { ProductId = 2, Title = "Laptop", Price = 899.99m, Description = "High performance laptop", Quantity = 15, ImagePath = "images/laptop.jpg", CategoryId = 1 },
                new Product { ProductId = 3, Title = "Headphones", Price = 59.99m, Description = "Noise cancelling headphones", Quantity = 30, ImagePath = "images/headphones.jpg", CategoryId = 1 },
                new Product { ProductId = 4, Title = "Novel", Price = 19.99m, Description = "Bestselling novel", Quantity = 50, ImagePath = "images/novel.jpg", CategoryId = 2 },
                new Product { ProductId = 5, Title = "Cookbook", Price = 29.99m, Description = "Delicious recipes", Quantity = 20, ImagePath = "images/cookbook.jpg", CategoryId = 2 },
                new Product { ProductId = 6, Title = "Textbook", Price = 79.99m, Description = "Educational textbook", Quantity = 25, ImagePath = "images/textbook.jpg", CategoryId = 2 },
                new Product { ProductId = 7, Title = "T-Shirt", Price = 25.00m, Description = "Cotton t-shirt", Quantity = 100, ImagePath = "images/tshirt.jpg", CategoryId = 3 },
                new Product { ProductId = 8, Title = "Jeans", Price = 49.99m, Description = "Denim jeans", Quantity = 60, ImagePath = "images/jeans.jpg", CategoryId = 3 },
                new Product { ProductId = 9, Title = "Jacket", Price = 89.99m, Description = "Winter jacket", Quantity = 40, ImagePath = "images/jacket.jpg", CategoryId = 3 },
                new Product { ProductId = 10, Title = "Sofa", Price = 399.99m, Description = "Comfortable sofa", Quantity = 5, ImagePath = "images/sofa.jpg", CategoryId = 4 },
                new Product { ProductId = 11, Title = "Lamp", Price = 39.99m, Description = "Desk lamp", Quantity = 20, ImagePath = "images/lamp.jpg", CategoryId = 4 },
                new Product { ProductId = 12, Title = "Blender", Price = 59.99m, Description = "Kitchen blender", Quantity = 15, ImagePath = "images/blender.jpg", CategoryId = 4 },
                new Product { ProductId = 13, Title = "Football", Price = 29.99m, Description = "Official size football", Quantity = 35, ImagePath = "images/football.jpg", CategoryId = 5 },
                new Product { ProductId = 14, Title = "Tennis Racket", Price = 79.99m, Description = "Professional tennis racket", Quantity = 10, ImagePath = "images/racket.jpg", CategoryId = 5 },
                new Product { ProductId = 15, Title = "Yoga Mat", Price = 24.99m, Description = "Non-slip yoga mat", Quantity = 50, ImagePath = "images/yogamat.jpg", CategoryId = 5 }
            };

            var users = new List<User>()
            {
                new User { UserId = 1, FirstName = "Alice", LastName = "Smith", Email = "alice.smith@example.com", Password = "Password123" },
                new User { UserId = 2, FirstName = "Bob", LastName = "Johnson", Email = "bob.johnson@example.com", Password = "Password456" },
                new User { UserId = 3, FirstName = "Charlie", LastName = "Brown", Email = "charlie.brown@example.com", Password = "Password789" },
                new User { UserId = 4, FirstName = "David", LastName = "Williams", Email = "david.williams@example.com", Password = "Password321" },
                new User { UserId = 5, FirstName = "Eve", LastName = "Davis", Email = "eve.davis@example.com", Password = "Password654" },
                new User { UserId = 6, FirstName = "Frank", LastName = "Miller", Email = "frank.miller@example.com", Password = "Password987" },
                new User { UserId = 7, FirstName = "Grace", LastName = "Wilson", Email = "grace.wilson@example.com", Password = "Password111" },
                new User { UserId = 8, FirstName = "Hank", LastName = "Moore", Email = "hank.moore@example.com", Password = "Password222" },
                new User { UserId = 9, FirstName = "Ivy", LastName = "Taylor", Email = "ivy.taylor@example.com", Password = "Password333" },
                new User { UserId = 10, FirstName = "Jack", LastName = "Anderson", Email = "jack.anderson@example.com", Password = "Password444" }
            };

            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Product>().HasData(products);
            modelBuilder.Entity<User>().HasData(users);

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
    }
}
