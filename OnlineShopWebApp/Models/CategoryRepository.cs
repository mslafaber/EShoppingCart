using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        //Property which returns all categories as a list
        public IEnumerable<Category> GetAllCategories => new List<Category>
        {
            //Instatiates the category with the direct properties that the category needs
            new Category
            {
                CategoryId=1,
                CategoryName="Tech Products",
                CategoryDescription="Technological Products which serve different functions"
            },
            new Category
            {
                CategoryId=2,
                CategoryName="Books",
                CategoryDescription="Physical Books and EBooks"
            },
            new Category
            {
                CategoryId=3,
                CategoryName="Fashion Items",
                CategoryDescription="Clothing, Footwear, Accessories and Formal Wear"
            }
        };
    }
}
