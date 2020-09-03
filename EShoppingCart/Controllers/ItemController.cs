using EShoppingCart.Interfaces;
using EShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EShoppingCart.ViewModels;

namespace EShoppingCart.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ItemController(IItemRepository itemRepository, ICategoryRepository categoryRepository)
        {
            _itemRepository = itemRepository;
            _categoryRepository = categoryRepository;
        }

        //the folowwing viewresult will return the Items in separate categories
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Item> items;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                items = _itemRepository.Items.OrderBy(p => p.ItemId);
                currentCategory = "All Items";
            }
            else
            {
                if (string.Equals("Electronic Items", _category, StringComparison.OrdinalIgnoreCase))
                    items = _itemRepository.Items.Where(p => p.Category.CategoryName.Equals("Electronic Items")).OrderBy(p => p.Name);
                else
                    items = _itemRepository.Items.Where(p => p.Category.CategoryName.Equals("Clothing Items")).OrderBy(p => p.Name);

                currentCategory = _category;
            }

            var itemListViewModel = new ItemListViewModel
            {
                Items = items,
                CurrentCategory = currentCategory
            };

            return View(itemListViewModel);
        }

    }
}
