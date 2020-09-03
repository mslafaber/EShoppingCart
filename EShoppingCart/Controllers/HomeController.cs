using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EShoppingCart.Models;
using EShoppingCart.Interfaces;
using EShoppingCart.ViewModels;

namespace EShoppingCart.Controllers
{
    public class HomeController : Controller
    {
        //following codes Inject the Item repository
        private readonly IItemRepository _itemRepository;
        public HomeController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        //The home page view will be returned fromt following function
        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredItems = _itemRepository.PreferredItems
            };
            return View(homeViewModel);
        }
    }
}
