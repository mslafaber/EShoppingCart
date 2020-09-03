using EShoppingCart.Interfaces;
using EShoppingCart.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShoppingCart.Controllers
{
    public class OrderController: Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }

        /*[Authorize]*/
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        //this action is used only for the form
        public IActionResult Checkout(Order order)
        { 
            if (ModelState.IsValid)
            {
                //if the model is valid the order is created
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return View(order);
            }

            return View(order);
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thankyou for your order! :) ";
            return View();
        }
    }
}

