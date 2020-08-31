using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppingCart.Interfaces;
using EShoppingCart.Models;

namespace EShoppingCart.Mocks
{
    //the mock will inherit from the interface - ICategoryRepository
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                //This property will return a list of categories
                return new List<Category>
                     {
                         new Category { CategoryName = "Electronic Items", Description = "All Electronic Items" },
                         new Category { CategoryName = "Clothing Items", Description = "All Clothing Items" }
                     };
            }
        }
    }
}
