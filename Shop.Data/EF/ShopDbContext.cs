﻿using Shop.Data.Configurations;
using Shop.Data.Entities;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.EF
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions options) : base(options)
        {
        }

       protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new AppConfigConfiguration());
            modelbuilder.ApplyConfiguration(new ProductConfiguration());
            modelbuilder.ApplyConfiguration(new CategoryConfiguration());
            modelbuilder.ApplyConfiguration(new ProductInCategoryConfiguration());
            // base.OnModelCreating(modelbuilder);
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<AppConfig> AppConfigs { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<CategoryTranslation> CategoryTranslations { get; set; }
        public DbSet<ProductInCategory> ProductInCategories { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<ProductTranslation> ProductTranslations { get; set; }

        public DbSet<Promotion> Promotions { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<Slide> Slides { get; set; }
    }
}