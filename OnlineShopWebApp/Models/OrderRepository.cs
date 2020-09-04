using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Models
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ShoppingCart _shoppingCart;

        public OrderRepository(AppDbContext appDbContext, ShoppingCart shoppingCart)
        {
            _appDbContext = appDbContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order) 
        {
            //update the time for the current time
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = _shoppingCart.GetShoppingCartTotal();

            _appDbContext.Orders.Add(order);
            //save the order before because of one to many
            _appDbContext.SaveChanges();

            //grab all the items from the shopping cart
            var shoppingCartItems = _shoppingCart.GetShoppingCartItems();

            //loop through the items and add them
            foreach (var shoppingCartItem in shoppingCartItems)
            {
                //create a new instance or each
                var orderDetail = new OrderDetail
                {
                    Amount = shoppingCartItem.Amount,
                    Price = shoppingCartItem.Item.Price,
                    ItemId = shoppingCartItem.Item.ItemId,
                    OrderId = order.OrderId
                };

                //add the new instance to the order detail data set
                _appDbContext.OrderDetails.Add(orderDetail);
            }

            _appDbContext.SaveChanges();
        }
    }
}
