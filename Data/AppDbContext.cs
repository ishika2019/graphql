﻿using GraphQLProject.Model;
using Microsoft.EntityFrameworkCore;

namespace GraphQLProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Menu> menus { get; set; }

       public DbSet<Category> categories { get; set; }

        public DbSet<Reservation> reservation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
              new Category { Id = 1, Name = "Appetizers", ImageUrl = "https://example.com/categories/appetizers.jpg" },
              new Category { Id = 2, Name = "Main Course", ImageUrl = "https://example.com/categories/main-course.jpg" },
              new Category { Id = 3, Name = "Desserts", ImageUrl = "https://example.com/categories/desserts.jpg" }
           );

            modelBuilder.Entity<Menu>().HasData(
               new Menu { Id = 1, Name = "Chicken Wings", Description = "Spicy chicken wings served with blue cheese dip.", Price = 9.99, ImageUrl = "https://example.com/menus/chicken-wings.jpg", CategoryId = 1 },
               new Menu { Id = 2, Name = "Steak", Description = "Grilled steak with mashed potatoes and vegetables.", Price = 24.50, ImageUrl = "https://example.com/menus/steak.jpg", CategoryId = 2 },
               new Menu { Id = 3, Name = "Chocolate Cake", Description = "Decadent chocolate cake with a scoop of vanilla ice cream.", Price = 6.95, ImageUrl = "https://example.com/menus/chocolate-cake.jpg", CategoryId = 3 }
            );

            modelBuilder.Entity<Reservation>().HasData(
               new Reservation { Id = 1, CustomerName = "John Doe", CustomerEmail = "johndoe@example.com", CustomerPhone = "555-123-4567", PartySize = 2, SpecialRequest = "No nuts in the dishes, please.", ReservationDate = DateTime.Now.AddDays(7) },
               new Reservation { Id = 2, CustomerName = "Jane Smith", CustomerEmail = "janesmith@example.com", CustomerPhone = "555-987-6543", PartySize = 4, SpecialRequest = "Gluten-free options required.", ReservationDate = DateTime.Now.AddDays(10) },
               new Reservation { Id = 3, CustomerName = "Michael Johnson", CustomerEmail = "michaeljohnson@example.com", CustomerPhone = "555-789-0123", PartySize = 6, SpecialRequest = "Celebrating a birthday.", ReservationDate = DateTime.Now.AddDays(14) }
           );
        }
    }
}
