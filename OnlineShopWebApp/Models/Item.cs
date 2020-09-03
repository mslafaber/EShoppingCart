using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ItemImageUrl { get; set; }
        public string ItemImageThumbnailUrl { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsInStock { get; set; }
        public int CategoryId { get; set; }

        //Category class is brought into the Item class since each item belongs to a category
        public Category Category { get; set; }
    }
}
