using EShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShoppingCart.ViewModels
{
    public class ShoppingCartViewModel
    {
        //first property below will get which shopping cart the Items belong to
        public ShoppingCart ShoppingCart { get; set; }
        //Second property will have the total value of the shopping cart
        public decimal ShoppingCartTotal { get; set; }
    }
}
