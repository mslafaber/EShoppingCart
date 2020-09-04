using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using OnlineShopWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Components
{
    //class inherits from View componenet base class
    public class ShoppingCartSummary : ViewComponent
    {
        //bring in an instance of the shopping class
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        //below method is Invoked automatically by asp
        public IViewComponentResult Invoke()
        {
            //get items from the shopping cart
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            //instance of the view model created before
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            //view that is returned is of type IViewComponent
            return View(shoppingCartViewModel);
        }
    }
}
