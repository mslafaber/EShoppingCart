using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using OnlineShopWebApp.ViewModels;

namespace OnlineShopWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IItemRepository _itemRepository;

        //inject the repository into a constructor
        public HomeController(IItemRepository itemRepository) 
        {
            _itemRepository = itemRepository;
        }

        //returns the Items on sale
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ItemOnSale = _itemRepository.GetItemsOnSale
            };
            return View(homeViewModel);
        }
    }
}
