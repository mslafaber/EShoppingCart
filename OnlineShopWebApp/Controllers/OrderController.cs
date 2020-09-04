using Microsoft.AspNetCore.Mvc;
using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Controllers
{
    public class OrderController:Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }


        public IActionResult Checkout()
        {
            return View();
        }

        //below will be processed only when the form is submitted
        [HttpPost]

        //below method processes the order
        public IActionResult Checkout(Order order)
        {
            //get all the items from the shopping cart
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();

            //validate if there is at least one item in the shopping cart
            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your shopping cart is empty");
            }

            //check if the cart is valid or not/all the data is bound correctly or not
            if (ModelState.IsValid)
            {
                //create the order after validating
                _orderRepository.CreateOrder(order);
                //clear the cart
                _shoppingCart.ClearCart();
                //user will be sent to the checkout complete page
                return RedirectToAction("CheckoutComplete");
            }

            //if the form was not validated then the user will get the view with the data that the user has already added
            return View(order);
        }

        //below action will display a message
        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thank you for your purchase!! Hope you enjoy our Products.";
            return View();
        }
    }
}
