using InventoryManagement.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Infrastructure
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Lazy Load
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(("Server =./; Integrated Security = False; Database = InventoryManagementDB"), b => b.MigrationsAssembly("InventoryManagement.Api"));
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseItem> PurchaseItems { get; set; }
        public DbSet<Vendor> Vendors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                        .HasOne<ProductCategory>()
                        .WithMany()
                        .HasForeignKey(p => p.ProductCategoryId);

            modelBuilder.Entity<Purchase>()
                        .HasOne<Vendor>()
                        .WithMany()
                        .HasForeignKey(p => p.VendorId);

            modelBuilder.Entity<PurchaseItem>()
                        .HasOne<Purchase>()
                        .WithMany()
                        .HasForeignKey(pi => pi.PurchaseId);

            modelBuilder.Entity<PurchaseItem>()
                        .HasOne<Product>()
                        .WithMany()
                        .HasForeignKey(pi => pi.ProductId);

            //seeding VendorTable
            modelBuilder.Entity<Vendor>().HasData(
                    new Vendor
                    {
                        Id = Guid.Parse("953dd08f-c28f-4874-b349-4be7ce73eaa0"),
                        Name = "Costco"
                    },
                    new Vendor
                    {
                        Id = Guid.Parse("db2efaee-39ae-4994-90eb-3d9190ea2beb"),
                        Name = "Sam's Club"
                    },
                    new Vendor
                    {
                        Id = Guid.Parse("fedb1c36-4180-4dc1-921f-53bc39a5e9f0"),
                        Name = "General Mills"
                    },
                    new Vendor
                    {
                        Id = Guid.Parse("e6c1f658-d288-4c43-a720-8886e73df726"),
                        Name = "Kroger"
                    });

            //seeding ProductCategoryTable
            modelBuilder.Entity<ProductCategory>().HasData(
                    new ProductCategory
                    {
                        Id = Guid.Parse("7e42a3b7-f02f-442d-97ef-2b13bb423414"),
                        Name = "Dairy"
                    },
                    new ProductCategory
                    {
                        Id = Guid.Parse("209bc539-de7d-4a75-9590-eabb17e2cf8d"),
                        Name = "Fruit"
                    },
                    new ProductCategory
                    {
                        Id = Guid.Parse("ba24f865-0af3-4ce1-b123-0f1dcd1e3020"),
                        Name = "Vegetables"
                    },
                    new ProductCategory
                    {
                        Id = Guid.Parse("5a077aa8-c217-4209-a70c-dd92c2d10b09"),
                        Name = "Meat"
                    },
                    new ProductCategory
                    {
                        Id = Guid.Parse("52411182-ff92-46ec-9233-a76ffb190339"),
                        Name = "Dry Goods"
                    });

            //seeding ProductTable
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        ProductCategoryId = Guid.Parse("7e42a3b7-f02f-442d-97ef-2b13bb423414"),
                        Brand = "Kroger",
                        Name = "Milk",
                        Description = "One Gallon of Milk"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        ProductCategoryId = Guid.Parse("5a077aa8-c217-4209-a70c-dd92c2d10b09"),
                        Brand = "Kroger",
                        Name = "Eggs",
                        Description = "One Carton of a Dozen Eggs"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        ProductCategoryId = Guid.Parse("209bc539-de7d-4a75-9590-eabb17e2cf8d"),
                        Brand = "Dole",
                        Name = "Honecrisp Apple",
                        Description = "One Honeycrisp Apple"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        ProductCategoryId = Guid.Parse("209bc539-de7d-4a75-9590-eabb17e2cf8d"),
                        Brand = "Dole",
                        Name = "Banana",
                        Description = "One Yellow Banana"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        ProductCategoryId = Guid.Parse("ba24f865-0af3-4ce1-b123-0f1dcd1e3020"),
                        Brand = "Dole",
                        Name = "Cucumber",
                        Description = "One Green Plump Cucumber"
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        ProductCategoryId = Guid.Parse("52411182-ff92-46ec-9233-a76ffb190339"),
                        Brand = "King Arthur",
                        Name = "Flour",
                        Description = "One Bag of Flour"
                    });
        }
    }
}

