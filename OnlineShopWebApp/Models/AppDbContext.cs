using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Models
{
    public class AppDbContext : DbContext
    {
        //following method will create Dbcontext options and apply to the appdbcontext class
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {
        }

        //specify which entities will be manages by dbsontext
        public DbSet<Item> Items { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        //Method used to populated data when the database runs for the first time.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Add category data
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Tech Products",});
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Books", });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Fashion Items", });

            //Add Item Data
            modelBuilder.Entity<Item>().HasData(new Item 
            {
                ItemId = 1,
                Name = "Samsung Galaxy S20",
                Price = 1250M,
                Description = "Samsung Galaxy S20; 6.2-inch display, smallest in the S20 series. Snapdragon 865/Exynos 990 chipset with 12GB RAM and 128GB storage. Powered by a 4000mAh battery. On the back is situated triple-camera setup: 12MP main sensor, one telephoto, and one ultra-wide camera.",
                CategoryId = 1,
                ItemImageUrl = "\\Images\\samsungS20.jpg",
                IsInStock = true,
                IsOnSale = false,
                ItemImageThumbnailUrl = "\\Images\\thumbnails\\samsungS20-small.jpg"
            });
            modelBuilder.Entity<Item>().HasData(new Item 
            {
                ItemId = 2,
                Name = "Mac Book Pro 2019",
                Price = 3999M,
                Description = "Apple Macbook Pro 16 2019 Space Grey Retina display, 2.3GHz 8 - core Intel Core i9,Turbo Boost up to 4.8GHz,with 16MB shared L3 cache",
                CategoryId = 1,
                ItemImageUrl = "\\Images\\mac.jpg",
                IsInStock = true,
                IsOnSale = true,
                ItemImageThumbnailUrl = "\\Images\\thumbnails\\mac-small.jpg"
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 3,
                Name = "Curling Iron",
                Price = 18M,
                Description = "Advanced Ceramic Infused Curling Iron. 13mm-25mm Conical and For Curls And Waves With Advanced Ceramic Infused",
                CategoryId = 1,
                ItemImageUrl = "\\Images\\iron.jpg",
                IsInStock = true,
                IsOnSale = true,
                ItemImageThumbnailUrl = "\\Images\\thumbnails\\iron-small.jpg"
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 4,
                Name = "Laptop - Dell",
                Price = 1300M,
                Description = "High power and reliability, include the Inspiron, 2-in-1 laptops, and full HD laptops!",
                CategoryId = 1,
                ItemImageUrl = "\\Images\\delllap.jpg",
                IsInStock = true,
                IsOnSale = true,
                ItemImageThumbnailUrl = "\\Images\\thumbnails\\delllap-small.jpg"
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 5,
                Name = "Microwave Oven",
                Price = 599M,
                Description = "Flatbed microwave. Panasonic 32L Inverter Sensor",
                CategoryId = 1,
                ItemImageUrl = "\\Images\\microwave.jpg",
                IsInStock = true,
                IsOnSale = false,
                ItemImageThumbnailUrl = "\\Images\\thumbnails\\microwave-small.jpg"
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 6,
                Name = "Milk and Honey Book",
                Price = 20M,
                Description = "Physical Book, Author: Rupi Kaur, New York Best Seller",
                CategoryId = 2,
                ItemImageUrl = "\\Images\\milkandhoney.jpg",
                IsInStock = true,
                IsOnSale = true,
                ItemImageThumbnailUrl = "\\Images\\thumbnails\\milkandhoney-small.jpg"
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 7,
                Name = "Guide to success and Business growth according to brad",
                Price = 120M,
                Description = "Physical Book, Author: Brad, Tips on path to success",
                CategoryId = 2,
                ItemImageUrl = "\\Images\\guidetosuccess.jpg",
                IsInStock = true,
                IsOnSale = true,
                ItemImageThumbnailUrl = "\\Images\\thumbnails\\guidetosuccess-small.jpg"
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 8,
                Name = "Harry Potter",
                Price = 70M,
                Description = "Physical Book, Author: J K Rowling, New York Best Seller, fan fiction",
                CategoryId = 2,
                ItemImageUrl = "\\Images\\harrypotter.jpg",
                IsInStock = true,
                IsOnSale = true,
                ItemImageThumbnailUrl = "\\Images\\thumbnails\\harrypotter-small.jpg"
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 9,
                Name = "Half Blood Price",
                Price = 39M,
                Description = "E Book, Can be purchased and read through e media.",
                CategoryId = 2,
                ItemImageUrl = "\\Images\\halfbloodprice.jpg",
                IsInStock = true,
                IsOnSale = false,
                ItemImageThumbnailUrl = "\\Images\\thumbnails\\halfbloodprice-small.jpg"
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 10,
                Name = "Laguage Learning Book",
                Price = 37M,
                Description = "E Book, Can choose a language to learn from the sections in the E book.",
                CategoryId = 2,
                ItemImageUrl = "\\Images\\language.jpg",
                IsInStock = true,
                IsOnSale = false,
                ItemImageThumbnailUrl = "\\Images\\thumbnails\\language-small.jpg"
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 11,
                Name = "White T Shirt",
                Price = 20M,
                Description = "Stretchy, light and inexpensive fabric and are easy to clean.",
                CategoryId = 3,
                ItemImageUrl = "\\Images\\whitet.jpg",
                IsInStock = true,
                IsOnSale = false,
                ItemImageThumbnailUrl = "\\Images\\thumbnails\\whitet-small.jpg"
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 12,
                Name = "Brown Men's Boots",
                Price = 35M,
                Description = "Light weighted and shiny. Comfortable wear. Adjustable size. Free pair of laces provided.",
                CategoryId = 3,
                ItemImageUrl = "\\Images\\boots.jpg",
                IsInStock = true,
                IsOnSale =true,
                ItemImageThumbnailUrl = "\\Images\\thumbnails\\boots-small.jpg"
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 13,
                Name = "Women's Office Coat",
                Price = 60M,
                Description = "Black and white check long coat. Long Sleeves and made in rough fabric.",
                CategoryId = 3,
                ItemImageUrl = "\\Images\\officecoat.jpg",
                IsInStock = true,
                IsOnSale = true,
                ItemImageThumbnailUrl = "\\Images\\thumbnails\\officecoat-small.jpg"
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 14,
                Name = "Casual White Dress",
                Price = 20M,
                Description = "Stretchy, white dress perfect for summer. Pockets included in both sides.",
                CategoryId = 3,
                ItemImageUrl = "\\Images\\casualdress.jpg",
                IsInStock = true,
                IsOnSale = true,
                ItemImageThumbnailUrl = "\\Images\\thumbnails\\casualdress-small.jpg"
            });
            modelBuilder.Entity<Item>().HasData(new Item
            {
                ItemId = 15,
                Name = "Wedding Heels",
                Price = 120M,
                Description = "White covered heels for brides.",
                CategoryId = 3,
                ItemImageUrl = "\\Images\\heels.jpg",
                IsInStock = true,
                IsOnSale = false,
                ItemImageThumbnailUrl = "\\Images\\thumbnails\\heels-small.jpg"
            });

        }
    }
}
