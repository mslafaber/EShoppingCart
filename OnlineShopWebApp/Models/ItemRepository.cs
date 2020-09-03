using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Models
{
    public class ItemRepository : IItemRepository
    {
        //the category interface since the category is needed as a field to each item
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        //Property for getting all Items
        public IEnumerable<Item> GetAllItems => new List<Item>
        {
            new Item
            {
                ItemId=1,
                Name="Samsung Galaxy S20",
                Price=1250M,
                Description="Samsung Galaxy S20; 6.2-inch display, smallest in the S20 series. Snapdragon 865/Exynos 990 chipset with 12GB RAM and 128GB storage. Powered by a 4000mAh battery. On the back is situated triple-camera setup: 12MP main sensor, one telephoto, and one ultra-wide camera.",
                Category = _categoryRepository.GetAllCategories.ToList()[0],
                ItemImageUrl="https://images.unsplash.com/photo-1583574333311-3a86605c76b2?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=891&q=80",
                IsInStock=true,
                IsOnSale=false,
                ItemImageThumbnailUrl="https://images.unsplash.com/photo-1583573636246-18cb2246697f?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=895&q=80"
            },
            new Item
            {
                ItemId=2,
                Name="White T Shirt",
                Price=20M,
                Description="Stretchy, light and inexpensive fabric and are easy to clean.",
                Category = _categoryRepository.GetAllCategories.ToList()[2],
                ItemImageUrl="https://images.unsplash.com/photo-1529374255404-311a2a4f1fd9?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1049&q=80",
                IsInStock=true,
                IsOnSale=false,
                ItemImageThumbnailUrl="https://images.unsplash.com/photo-1529374255404-311a2a4f1fd9?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1049&q=80"
            },
            new Item
            {
                ItemId=3,
                Name="Milk and Honey Book",
                Price=70M,
                Description="Physical Book, Author: Rupi Kaur, New York Best Seller",
                Category = _categoryRepository.GetAllCategories.ToList()[1],
                ItemImageUrl="https://images.unsplash.com/photo-1544947950-fa07a98d237f?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=334&q=80",
                IsInStock=true,
                IsOnSale=true,
                ItemImageThumbnailUrl="https://images.unsplash.com/photo-1544947950-fa07a98d237f?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=334&q=80"
            }
        };

        //Tests is everything is working fine
        public IEnumerable<Item> GetItemsOnSale => throw new NotImplementedException();

        //below method will filter the Item that matches the Id by getting all items and matching the id
        public Item GetItemById(int itemId)
        {
            return GetAllItems.FirstOrDefault(c => c.ItemId == itemId);
        }
    }
}
