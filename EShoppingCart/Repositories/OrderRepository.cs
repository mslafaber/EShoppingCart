using EShoppingCart.Data;
using EShoppingCart.Interfaces;
using EShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShoppingCart.Repositories
{
    //Inherit from IOrderRepository
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(ApplicationDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            //add the order to the orders using application db context
            _appDbContext.Orders.Add(order);

            //get all the shopping cart items
            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            //for each shopping cart item an order detail record in created from teh following function
            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = shoppingCartItem.Amount,
                    ItemId = shoppingCartItem.Item.ItemId,
                    OrderId = order.OrderId,
                    Price = shoppingCartItem.Item.Price
                };
                //each order detail created it is added to the application db context as below.
                _appDbContext.OrderDetails.Add(orderDetail);
            }
        }
    }
}
