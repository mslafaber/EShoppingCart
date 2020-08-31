using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppingCart.Interfaces;
using EShoppingCart.Models;

namespace EShoppingCart.Mocks
{
    //the mock will inherit from the interface - IItemRepository
    public class MockItemRepository:IItemRepository
    {
        //Reference the MochCategoryRepository because the items have a property named Category
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        //Get the Items property from IItemRepository as below.
        public IEnumerable<Item> Items
        {
            get
            {
                return new List<Item>
                {
                    new Item {
                        Name = "MacBook Pro",
                        Price = 7.95M,
                        ItemDescription = "MacBook Pro description",
                        Category = _categoryRepository.Categories.First(),
                        ItemImageUrl = "https://images.unsplash.com/photo-1548611635-b6e7827d7d4a?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80",
                        InStock = true,
                        IsPrefferedItem = true,
                        ItemImageThumbnailUrl = "https://images.unsplash.com/photo-1548611635-b6e7827d7d4a?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80"
                    },
                    new Item {
                        Name = "White Tshirt",
                        Price = 12.95M,
                        ItemDescription = "White Tshirt Description",
                        Category =  _categoryRepository.Categories.First(),
                        ItemImageUrl = "https://images.unsplash.com/photo-1529374255404-311a2a4f1fd9?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1049&q=80",
                        InStock = true,
                        IsPrefferedItem = false,
                        ItemImageThumbnailUrl = "https://images.unsplash.com/photo-1529374255404-311a2a4f1fd9?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1049&q=80"
                    },
                    new Item {
                        Name = "IPhone 7 Mobile Phone",
                        Price = 12.95M,
                        ItemDescription = "IPhone 7 Description",
                        Category =  _categoryRepository.Categories.First(),
                        ItemImageUrl = "https://images.unsplash.com/photo-1545984306-9143a47b0f6e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80",
                        InStock = true,
                        IsPrefferedItem = false,
                        ItemImageThumbnailUrl = "https://images.unsplash.com/photo-1545984306-9143a47b0f6e?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80"
                    },
                    new Item
                    {
                        Name = "Sneakers",
                        Price = 12.95M,
                        ItemDescription = "Sneakers Description",
                        Category = _categoryRepository.Categories.Last(),
                        ItemImageUrl = "https://images.unsplash.com/photo-1552346154-21d32810aba3?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80",
                        InStock = true,
                        IsPrefferedItem = false,
                        ItemImageThumbnailUrl = "https://images.unsplash.com/photo-1552346154-21d32810aba3?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80"
                    }
                };
            }
        }
        //Get the PrefferedItems property from IItemRepository as below.
        public IEnumerable<Item> PreferredItems { get; }
        public Item GetItemById(int itemId)
        {
            throw new NotImplementedException();
        }
    }
}
