﻿using Gorev7P013.Models;
using Microsoft.EntityFrameworkCore;

namespace Gorev7P013.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; database=Gorev7P013; trusted_connection=true");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User 
                {
                    Id = 1,
                    Email = "admin@Gorev7P013.com",
                    IsActive = true,
                    IsAdmin = true,
                    Name = "Admin",
                    Password = "123"
                }
                );
            
            modelBuilder.Entity<Category>().HasData( 
                new Category
                {
                    Id = 1,
                    Name = "Elektronik"
                },
                new Category
                {
                    Id = 2,
                    Name = "Bilgisayar"
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
