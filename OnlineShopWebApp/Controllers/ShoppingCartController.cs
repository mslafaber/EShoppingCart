using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using OnlineShopWebApp.Models;
using OnlineShopWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IItemRepository _itemRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IItemRepository itemRepository, ShoppingCart shoppingCart)
        {
            _itemRepository = itemRepository;
            _shoppingCart = shoppingCart;
        }

        //first action to return the cart and the total to the view
        public ViewResult Index()
        {
            //get all the values from the shopping cart
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            //combine the items and the total amount into a view model
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        //below action will add items to the shopping cart
        public RedirectToActionResult AddToShoppingCart(int itemId)
        {
            //get the item from the repository which matches the ID that is being passed
            var selectedItem = _itemRepository.GetAllItems.FirstOrDefault(c => c.ItemId == itemId);

            //check if the item exist add it to the cart
            if (selectedItem != null)
            {
                _shoppingCart.AddToCart(selectedItem, 1);
            }

            //after an item is added the user is redirected to the shopping cart index action which will show the updated shopping cart
            return RedirectToAction("Index");
        }

        //action which will remove items from the cart
        public RedirectToActionResult RemoveFromShoppingCart(int itemId)
        {
            //get the item from the repository which matches the ID that is being passed
            var selectedItem = _itemRepository.GetAllItems.FirstOrDefault(c => c.ItemId == itemId);

            //check if the item exist add it to the cart
            if (selectedItem != null)
            {
                _shoppingCart.RemoveFromCart(selectedItem);
            }

            //after an item is added the user is redirected to the shopping cart index action which will show the updated shopping cart
            return RedirectToAction("Index");
        }

        //action to clear the cart
        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }
    }
}
