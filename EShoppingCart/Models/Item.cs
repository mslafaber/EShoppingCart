using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace EShoppingCart.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string ItemDescription { get; set; }
        public decimal Price { get; set; }
        public string ItemImageUrl { get; set; }
        public string ItemImageThumbnailUrl { get; set; }

        //If an item is preffered the item will be shown in the main page
        public bool IsPrefferedItem { get; set; }
        //InStock property Shows if the item is actually in stock or not. If the item is not in stock the view will be shown to the user
        public bool InStock { get; set; }
        //This has only one category which means an item belongs to only one category but a category can have many items
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
