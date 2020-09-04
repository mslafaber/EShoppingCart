using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Components
{
    //inherit from the ViewComponent
    public class CategoryMenu : ViewComponent
    {
        //bring in the category repository
        private readonly ICategoryRepository _categoryRepository;
        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        //Invoke method is needed since this is a view component
        public IViewComponentResult Invoke()
        {
            //get all the categories from the category repository ordered by the Category name
            var categories = _categoryRepository.GetAllCategories.OrderBy(c => c.CategoryName);

            return View(categories);
        }
    }
}
