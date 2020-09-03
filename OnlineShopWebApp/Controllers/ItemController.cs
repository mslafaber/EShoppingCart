using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
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

        public ViewResult List() 
        {
            return View(_itemRepository.GetAllItems);
        }
    }
}
