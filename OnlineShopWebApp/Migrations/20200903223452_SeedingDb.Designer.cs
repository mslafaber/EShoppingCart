﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineShopWebApp.Models;

namespace OnlineShopWebApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200903223452_SeedingDb")]
    partial class SeedingDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineShopWebApp.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Tech Products"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Books"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Fashion Items"
                        });
                });

            modelBuilder.Entity("OnlineShopWebApp.Models.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("ItemImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ItemId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            CategoryId = 1,
                            Description = "Samsung Galaxy S20; 6.2-inch display, smallest in the S20 series. Snapdragon 865/Exynos 990 chipset with 12GB RAM and 128GB storage. Powered by a 4000mAh battery. On the back is situated triple-camera setup: 12MP main sensor, one telephoto, and one ultra-wide camera.",
                            IsInStock = true,
                            IsOnSale = false,
                            ItemImageThumbnailUrl = "\\Images\\thumbnails\\samsungS20-small.jpg",
                            ItemImageUrl = "\\Images\\samsungS20.jpg",
                            Name = "Samsung Galaxy S20",
                            Price = 1250m
                        },
                        new
                        {
                            ItemId = 2,
                            CategoryId = 1,
                            Description = "Apple Macbook Pro 16 2019 Space Grey Retina display, 2.3GHz 8 - core Intel Core i9,Turbo Boost up to 4.8GHz,with 16MB shared L3 cache",
                            IsInStock = true,
                            IsOnSale = true,
                            ItemImageThumbnailUrl = "\\Images\\thumbnails\\mac-small.jpg",
                            ItemImageUrl = "\\Images\\mac.jpg",
                            Name = "Mac Book Pro 2019",
                            Price = 3999m
                        },
                        new
                        {
                            ItemId = 3,
                            CategoryId = 1,
                            Description = "Advanced Ceramic Infused Curling Iron. 13mm-25mm Conical and For Curls And Waves With Advanced Ceramic Infused",
                            IsInStock = true,
                            IsOnSale = true,
                            ItemImageThumbnailUrl = "\\Images\\thumbnails\\iron-small.jpg",
                            ItemImageUrl = "\\Images\\iron.jpg",
                            Name = "Curling Iron",
                            Price = 18m
                        },
                        new
                        {
                            ItemId = 4,
                            CategoryId = 1,
                            Description = "High power and reliability, include the Inspiron, 2-in-1 laptops, and full HD laptops!",
                            IsInStock = true,
                            IsOnSale = true,
                            ItemImageThumbnailUrl = "\\Images\\thumbnails\\delllap-small.jpg",
                            ItemImageUrl = "\\Images\\delllap.jpg",
                            Name = "Laptop - Dell",
                            Price = 1300m
                        },
                        new
                        {
                            ItemId = 5,
                            CategoryId = 1,
                            Description = "Flatbed microwave. Panasonic 32L Inverter Sensor",
                            IsInStock = true,
                            IsOnSale = false,
                            ItemImageThumbnailUrl = "\\Images\\thumbnails\\microwave-small.jpg",
                            ItemImageUrl = "\\Images\\microwave.jpg",
                            Name = "Microwave Oven",
                            Price = 599m
                        },
                        new
                        {
                            ItemId = 6,
                            CategoryId = 2,
                            Description = "Physical Book, Author: Rupi Kaur, New York Best Seller",
                            IsInStock = true,
                            IsOnSale = true,
                            ItemImageThumbnailUrl = "\\Images\\thumbnails\\milkandhoney-small.jpg",
                            ItemImageUrl = "\\Images\\milkandhoney.jpg",
                            Name = "Milk and Honey Book",
                            Price = 20m
                        },
                        new
                        {
                            ItemId = 7,
                            CategoryId = 2,
                            Description = "Physical Book, Author: Brad, Tips on path to success",
                            IsInStock = true,
                            IsOnSale = true,
                            ItemImageThumbnailUrl = "\\Images\\thumbnails\\guidetosuccess-small.jpg",
                            ItemImageUrl = "\\Images\\guidetosuccess.jpg",
                            Name = "Guide to success and Business growth according to brad",
                            Price = 120m
                        },
                        new
                        {
                            ItemId = 8,
                            CategoryId = 2,
                            Description = "Physical Book, Author: J K Rowling, New York Best Seller, fan fiction",
                            IsInStock = true,
                            IsOnSale = true,
                            ItemImageThumbnailUrl = "\\Images\\thumbnails\\harrypotter-small.jpg",
                            ItemImageUrl = "\\Images\\harrypotter.jpg",
                            Name = "Harry Potter",
                            Price = 70m
                        },
                        new
                        {
                            ItemId = 9,
                            CategoryId = 2,
                            Description = "E Book, Can be purchased and read through e media.",
                            IsInStock = true,
                            IsOnSale = false,
                            ItemImageThumbnailUrl = "\\Images\\thumbnails\\halfbloodprice-small.jpg",
                            ItemImageUrl = "\\Images\\halfbloodprice.jpg",
                            Name = "Half Blood Price",
                            Price = 39m
                        },
                        new
                        {
                            ItemId = 10,
                            CategoryId = 2,
                            Description = "E Book, Can choose a language to learn from the sections in the E book.",
                            IsInStock = true,
                            IsOnSale = false,
                            ItemImageThumbnailUrl = "\\Images\\thumbnails\\language-small.jpg",
                            ItemImageUrl = "\\Images\\language.jpg",
                            Name = "Laguage Learning Book",
                            Price = 37m
                        },
                        new
                        {
                            ItemId = 11,
                            CategoryId = 3,
                            Description = "Stretchy, light and inexpensive fabric and are easy to clean.",
                            IsInStock = true,
                            IsOnSale = false,
                            ItemImageThumbnailUrl = "\\Images\\thumbnails\\whitet-small.jpg",
                            ItemImageUrl = "\\Images\\whitet.jpg",
                            Name = "White T Shirt",
                            Price = 20m
                        },
                        new
                        {
                            ItemId = 12,
                            CategoryId = 3,
                            Description = "Light weighted and shiny. Comfortable wear. Adjustable size. Free pair of laces provided.",
                            IsInStock = true,
                            IsOnSale = true,
                            ItemImageThumbnailUrl = "\\Images\\thumbnails\\boots-small.jpg",
                            ItemImageUrl = "\\Images\\boots.jpg",
                            Name = "Brown Men's Boots",
                            Price = 35m
                        },
                        new
                        {
                            ItemId = 13,
                            CategoryId = 3,
                            Description = "Black and white check long coat. Long Sleeves and made in rough fabric.",
                            IsInStock = true,
                            IsOnSale = true,
                            ItemImageThumbnailUrl = "\\Images\\thumbnails\\officecoat-small.jpg",
                            ItemImageUrl = "\\Images\\officecoat.jpg",
                            Name = "Women's Office Coat",
                            Price = 60m
                        },
                        new
                        {
                            ItemId = 14,
                            CategoryId = 3,
                            Description = "Stretchy, white dress perfect for summer. Pockets included in both sides.",
                            IsInStock = true,
                            IsOnSale = true,
                            ItemImageThumbnailUrl = "\\Images\\thumbnails\\casualdress-small.jpg",
                            ItemImageUrl = "\\Images\\casualdress.jpg",
                            Name = "Casual White Dress",
                            Price = 20m
                        },
                        new
                        {
                            ItemId = 15,
                            CategoryId = 3,
                            Description = "White covered heels for brides.",
                            IsInStock = true,
                            IsOnSale = false,
                            ItemImageThumbnailUrl = "\\Images\\thumbnails\\heels-small.jpg",
                            ItemImageUrl = "\\Images\\heels.jpg",
                            Name = "Wedding Heels",
                            Price = 120m
                        });
                });

            modelBuilder.Entity("OnlineShopWebApp.Models.Item", b =>
                {
                    b.HasOne("OnlineShopWebApp.Models.Category", "Category")
                        .WithMany("Items")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}