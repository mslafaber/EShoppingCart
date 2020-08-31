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

        //Following method will return a list of Items so named it "List"
        public ViewResult List()
        {
            ViewBag.Name = "DotNet, How?";
            var items = _itemRepository.Items;
            ItemListViewModel vm = new ItemListViewModel();
            vm.Items = _itemRepository.Items;
            vm.CurrentCategory = "Item Category";

            return View(vm);
        }

        /*public ViewResult List(string category)
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
                if (string.Equals("Alcoholic", _category, StringComparison.OrdinalIgnoreCase))
                    items = _itemRepository.Items.Where(p => p.Category.CategoryName.Equals("Alcoholic")).OrderBy(p => p.Name);
                else
                    items = _itemRepository.Items.Where(p => p.Category.CategoryName.Equals("Non-alcoholic")).OrderBy(p => p.Name);

                currentCategory = _category;
            }

            return View(new ItemsListViewModel
            {
                Items = items,
                CurrentCategory = currentCategory
            });
        }

        public ViewResult Search(string searchString)
        {
            string _searchString = searchString;
            IEnumerable<Item> drinks;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(_searchString))
            {
                drinks = _itemRepository.Items.OrderBy(p => p.ItemId);
            }
            else
            {
                drinks = _itemRepository.Items.Where(p => p.Name.ToLower().Contains(_searchString.ToLower()));
            }

            return View("~/Views/Drink/List.cshtml", new ItemsListViewModel { Drinks = drinks, CurrentCategory = "All drinks" });
        }

        public ViewResult Details(int drinkId)
        {
            var drink = _itemRepository.Items.FirstOrDefault(d => d.ItemId == drinkId);
            if (drink == null)
            {
                return View("~/Views/Error/Error.cshtml");
            }
            return View(drink);
        }*/
/*
        public IActionResult Index()
        {
            return View();
        }*/
    }
}
