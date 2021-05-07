using FoodDeliveryProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDeliveryProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Category>().ToTable("Category");
            builder.Entity<Place>().ToTable("Place");
            builder.Entity<Item>().ToTable("Item");
            builder.Entity<UserAddress>().ToTable("UserAddress");
            builder.Entity<Order>().ToTable("Order");
            base.OnModelCreating(builder);
        }
    }
}
