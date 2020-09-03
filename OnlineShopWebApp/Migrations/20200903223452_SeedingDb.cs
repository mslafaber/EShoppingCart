using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShopWebApp.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 1, null, "Tech Products" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 2, null, "Books" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[] { 3, null, "Fashion Items" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "CategoryId", "Description", "IsInStock", "IsOnSale", "ItemImageThumbnailUrl", "ItemImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "Samsung Galaxy S20; 6.2-inch display, smallest in the S20 series. Snapdragon 865/Exynos 990 chipset with 12GB RAM and 128GB storage. Powered by a 4000mAh battery. On the back is situated triple-camera setup: 12MP main sensor, one telephoto, and one ultra-wide camera.", true, false, "\\Images\\thumbnails\\samsungS20-small.jpg", "\\Images\\samsungS20.jpg", "Samsung Galaxy S20", 1250m },
                    { 2, 1, "Apple Macbook Pro 16 2019 Space Grey Retina display, 2.3GHz 8 - core Intel Core i9,Turbo Boost up to 4.8GHz,with 16MB shared L3 cache", true, true, "\\Images\\thumbnails\\mac-small.jpg", "\\Images\\mac.jpg", "Mac Book Pro 2019", 3999m },
                    { 3, 1, "Advanced Ceramic Infused Curling Iron. 13mm-25mm Conical and For Curls And Waves With Advanced Ceramic Infused", true, true, "\\Images\\thumbnails\\iron-small.jpg", "\\Images\\iron.jpg", "Curling Iron", 18m },
                    { 4, 1, "High power and reliability, include the Inspiron, 2-in-1 laptops, and full HD laptops!", true, true, "\\Images\\thumbnails\\delllap-small.jpg", "\\Images\\delllap.jpg", "Laptop - Dell", 1300m },
                    { 5, 1, "Flatbed microwave. Panasonic 32L Inverter Sensor", true, false, "\\Images\\thumbnails\\microwave-small.jpg", "\\Images\\microwave.jpg", "Microwave Oven", 599m },
                    { 6, 2, "Physical Book, Author: Rupi Kaur, New York Best Seller", true, true, "\\Images\\thumbnails\\milkandhoney-small.jpg", "\\Images\\milkandhoney.jpg", "Milk and Honey Book", 20m },
                    { 7, 2, "Physical Book, Author: Brad, Tips on path to success", true, true, "\\Images\\thumbnails\\guidetosuccess-small.jpg", "\\Images\\guidetosuccess.jpg", "Guide to success and Business growth according to brad", 120m },
                    { 8, 2, "Physical Book, Author: J K Rowling, New York Best Seller, fan fiction", true, true, "\\Images\\thumbnails\\harrypotter-small.jpg", "\\Images\\harrypotter.jpg", "Harry Potter", 70m },
                    { 9, 2, "E Book, Can be purchased and read through e media.", true, false, "\\Images\\thumbnails\\halfbloodprice-small.jpg", "\\Images\\halfbloodprice.jpg", "Half Blood Price", 39m },
                    { 10, 2, "E Book, Can choose a language to learn from the sections in the E book.", true, false, "\\Images\\thumbnails\\language-small.jpg", "\\Images\\language.jpg", "Laguage Learning Book", 37m },
                    { 11, 3, "Stretchy, light and inexpensive fabric and are easy to clean.", true, false, "\\Images\\thumbnails\\whitet-small.jpg", "\\Images\\whitet.jpg", "White T Shirt", 20m },
                    { 12, 3, "Light weighted and shiny. Comfortable wear. Adjustable size. Free pair of laces provided.", true, true, "\\Images\\thumbnails\\boots-small.jpg", "\\Images\\boots.jpg", "Brown Men's Boots", 35m },
                    { 13, 3, "Black and white check long coat. Long Sleeves and made in rough fabric.", true, true, "\\Images\\thumbnails\\officecoat-small.jpg", "\\Images\\officecoat.jpg", "Women's Office Coat", 60m },
                    { 14, 3, "Stretchy, white dress perfect for summer. Pockets included in both sides.", true, true, "\\Images\\thumbnails\\casualdress-small.jpg", "\\Images\\casualdress.jpg", "Casual White Dress", 20m },
                    { 15, 3, "White covered heels for brides.", true, false, "\\Images\\thumbnails\\heels-small.jpg", "\\Images\\heels.jpg", "Wedding Heels", 120m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
