using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppingCart.Interfaces;
using EShoppingCart.Models;
using EShoppingCart.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EShoppingCart.Controllers
{
    public class ShoppingCartController : Controller
    {
        //below methods will enable to interact with Items and the shopping cart
        private readonly IItemRepository _itemRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IItemRepository itemRepository, ShoppingCart shoppingCart)
        {
            _itemRepository = itemRepository;
            _shoppingCart = shoppingCart;
        }

        //return a view of the shopping cart using the following function
        public ViewResult Index() 
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            //import the shopping cart view model as below
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            //user will be given the view of the shopping cart
            return View(shoppingCartViewModel);
        }

        //user will be able confirm if they want to add item using the below redirect function
        public RedirectToActionResult AddToShoppingCart(int itemId)
        {
            var selectedItem = _itemRepository.Items.FirstOrDefault(p => p.ItemId == itemId);
            if (selectedItem != null)
            {
                _shoppingCart.AddToCart(selectedItem, 1);
            }
            return RedirectToAction("Index");
        }

        //user will be able to remove items form the cart using below function after checking for items in the cart
        public RedirectToActionResult RemoveFromShoppingCart(int itemId)
        {
            var selectedItem = _itemRepository.Items.FirstOrDefault(p => p.ItemId == itemId);
            if (selectedItem != null)
            {
                _shoppingCart.RemoveFromCart(selectedItem);
            }
            return RedirectToAction("Index");
        }
    }
}
