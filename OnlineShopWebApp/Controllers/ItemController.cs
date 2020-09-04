using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using OnlineShopWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Controllers
{
    public class ItemController:Controller
    {
        //Bring the repositories into the class to use the data from the repositories, by creating read only fields for the interfaces
        private readonly IItemRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;

        //Below constructor will instantiate interfaces above by injecting
        public ItemController(IItemRepository itemRepository, ICategoryRepository categoryRepository)
        {
            _itemRepository = itemRepository;
            _categoryRepository = categoryRepository;
        }

        //action methods are as below

        //folowing method will retrieve the items belonging to a certain category as selected from the dropdown list with the correct category name
        public ViewResult List(string category) 
        {
            IEnumerable<Item> items;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                items = _itemRepository.GetAllItems.OrderBy(c => c.ItemId);
                currentCategory = "All Types of Items";
            }
            else 
            {
                items = _itemRepository.GetAllItems.Where(c => c.Category.CategoryName == category);
                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(currentCategory => currentCategory.CategoryName == category)?.CategoryName;
            }
            return View(new ItemListViewModel
            {
                Items = items,
                CurrentCategory = currentCategory
            });
        }

        //view details of the item
        public IActionResult Details(int id)
        {
            var item = _itemRepository.GetItemById(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }
    }
}
