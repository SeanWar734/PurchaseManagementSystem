﻿// <auto-generated />
using System;
using InventoryManagement.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace InventoryManagement.Api.Migrations
{
    [DbContext(typeof(InventoryContext))]
    partial class InventoryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InventoryManagement.Core.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Brand")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("ProductCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ab9624f3-65eb-4d88-a565-66ba27089c2d"),
                            Brand = "Kroger",
                            Description = "One Gallon of Milk",
                            Name = "Milk",
                            ProductCategoryId = new Guid("7e42a3b7-f02f-442d-97ef-2b13bb423414")
                        },
                        new
                        {
                            Id = new Guid("66f8d272-68f9-4e69-a2aa-af66ee21977c"),
                            Brand = "Kroger",
                            Description = "One Carton of a Dozen Eggs",
                            Name = "Eggs",
                            ProductCategoryId = new Guid("5a077aa8-c217-4209-a70c-dd92c2d10b09")
                        },
                        new
                        {
                            Id = new Guid("91172686-07a1-4eaa-b7a3-41d84f11e105"),
                            Brand = "Dole",
                            Description = "One Honeycrisp Apple",
                            Name = "Honecrisp Apple",
                            ProductCategoryId = new Guid("209bc539-de7d-4a75-9590-eabb17e2cf8d")
                        },
                        new
                        {
                            Id = new Guid("4cacff9c-c5ba-4d07-87af-476ef6d4fc79"),
                            Brand = "Dole",
                            Description = "One Yellow Banana",
                            Name = "Banana",
                            ProductCategoryId = new Guid("209bc539-de7d-4a75-9590-eabb17e2cf8d")
                        },
                        new
                        {
                            Id = new Guid("79c4df5f-bf1c-46f6-94e0-9e118d7c8a86"),
                            Brand = "Dole",
                            Description = "One Green Plump Cucumber",
                            Name = "Cucumber",
                            ProductCategoryId = new Guid("ba24f865-0af3-4ce1-b123-0f1dcd1e3020")
                        },
                        new
                        {
                            Id = new Guid("90725252-8a2b-46de-99d7-a01241745550"),
                            Brand = "King Arthur",
                            Description = "One Bag of Flour",
                            Name = "Flour",
                            ProductCategoryId = new Guid("52411182-ff92-46ec-9233-a76ffb190339")
                        });
                });

            modelBuilder.Entity("InventoryManagement.Core.ProductCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7e42a3b7-f02f-442d-97ef-2b13bb423414"),
                            Name = "Dairy"
                        },
                        new
                        {
                            Id = new Guid("209bc539-de7d-4a75-9590-eabb17e2cf8d"),
                            Name = "Fruit"
                        },
                        new
                        {
                            Id = new Guid("ba24f865-0af3-4ce1-b123-0f1dcd1e3020"),
                            Name = "Vegetables"
                        },
                        new
                        {
                            Id = new Guid("5a077aa8-c217-4209-a70c-dd92c2d10b09"),
                            Name = "Meat"
                        },
                        new
                        {
                            Id = new Guid("52411182-ff92-46ec-9233-a76ffb190339"),
                            Name = "Dry Goods"
                        });
                });

            modelBuilder.Entity("InventoryManagement.Core.Purchase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReferenceNumber")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("VendorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("VendorId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("InventoryManagement.Core.PurchaseItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Notes")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PurchaseId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UOM")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("PurchaseId");

                    b.ToTable("PurchaseItems");
                });

            modelBuilder.Entity("InventoryManagement.Core.Vendor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Vendors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("953dd08f-c28f-4874-b349-4be7ce73eaa0"),
                            Name = "Costco"
                        },
                        new
                        {
                            Id = new Guid("db2efaee-39ae-4994-90eb-3d9190ea2beb"),
                            Name = "Sam's Club"
                        },
                        new
                        {
                            Id = new Guid("fedb1c36-4180-4dc1-921f-53bc39a5e9f0"),
                            Name = "General Mills"
                        },
                        new
                        {
                            Id = new Guid("e6c1f658-d288-4c43-a720-8886e73df726"),
                            Name = "Kroger"
                        });
                });

            modelBuilder.Entity("InventoryManagement.Core.Product", b =>
                {
                    b.HasOne("InventoryManagement.Core.ProductCategory", null)
                        .WithMany()
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InventoryManagement.Core.Purchase", b =>
                {
                    b.HasOne("InventoryManagement.Core.Vendor", null)
                        .WithMany()
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InventoryManagement.Core.PurchaseItem", b =>
                {
                    b.HasOne("InventoryManagement.Core.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InventoryManagement.Core.Purchase", null)
                        .WithMany()
                        .HasForeignKey("PurchaseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
