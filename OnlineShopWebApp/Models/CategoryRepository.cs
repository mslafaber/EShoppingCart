using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        //Use AppDbContext to get the db data for categories
        private readonly AppDbContext _appDbContext;

        //to use the above field inject it to a constructor as shown below
        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //Property which returns all categories from the db
        public IEnumerable<Category> GetAllCategories => _appDbContext.Categories;
    }
}

/*public IEnumerable<Category> GetAllCategories => new List<Category>
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
        };*/
