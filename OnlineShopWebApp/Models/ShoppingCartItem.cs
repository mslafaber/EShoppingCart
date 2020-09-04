using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public string ShoppingCartId { get; set; }
        
        //following property in order to know what Item is in the cart
        public Item Item { get; set; }

        //following property in order to know the quatity of each item
        public int Amount { get; set; }
    }
}
