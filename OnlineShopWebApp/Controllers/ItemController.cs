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

        public IActionResult List() 
        {
            /*ViewBag.CurrentCategory = "BestSeller";
            return View(_itemRepository.GetAllItems);*/

            //get an instance of the view model
            var itemListViewModel = new ItemListViewModel();
            itemListViewModel.Items = _itemRepository.GetAllItems;
            itemListViewModel.CurrentCategory = "Best Sellers";

            return View(itemListViewModel);
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
