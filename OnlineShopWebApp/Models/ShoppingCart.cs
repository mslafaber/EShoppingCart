using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Models
{
    public class ShoppingCart
    {
        //get the Db context as below and inject to the contructor as shown below in order to access the database data
        private readonly AppDbContext _appDbContext;
        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
        public ShoppingCart(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }

        //method that returns the whole shopping cart
        public static ShoppingCart GetCart(IServiceProvider services) 
        {
            //if this is null and try to access this an exception will be thrown
            //below line will also do a null check
            ISession session = services.GetRequiredService<IHttpContextAccessor>
                ()?.HttpContext.Session;

            //method to get the current dbcontext from servies
            var context = services.GetService<AppDbContext>();

            //turnary operator with a null check which asks whether or not the session get string get a value
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            //returns a new instance of the cart
            return new ShoppingCart(context)
            {
                ShoppingCartId = cartId
            };

        }

        //below method will add item to the shopping cart
        public void AddToCart(Item item, int amount)
        {
            //check if the item id and cart if exists
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(
                s => s.Item.ItemId == item.ItemId && s.ShoppingCartId == ShoppingCartId);

            //check if the shopping cart item is null or not
            if (shoppingCartItem == null)
            {
                //then adding the first item to the cart
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Item = item,
                    Amount = amount
                };

                //add it to the dataset
                _appDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                //Increases the amount of item in the cart
                shoppingCartItem.Amount++;
            }

            _appDbContext.SaveChanges();
        }

        //below method allows user to remove items from the cart
        public int RemoveFromCart(Item item)
        {
            //check if the item id and shopping cart id exists
            var shoppingCartItem = _appDbContext.ShoppingCartItems.SingleOrDefault(
                s => s.Item.ItemId == item.ItemId && s.ShoppingCartId == ShoppingCartId);

            //counter which is used to decrease the quantity of items in the shopping cart
            var localAmount = 0;

            //checks if the item is null or not
            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Amount > 1)
                {
                    //the quantity is greater than 1 the decrease by 1
                    shoppingCartItem.Amount--;
                    localAmount = shoppingCartItem.Amount;
                }
                else
                {
                    //if the quantity is 1 the item is removed from the cart
                    _appDbContext.ShoppingCartItems.Remove(shoppingCartItem);
                }
            }

            _appDbContext.SaveChanges();

            //returns the new amount of item in the cart
            return localAmount;
        }

        //below method will get all the items in the cart as a list
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (ShoppingCartItems = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Include(s => s.Item)
                .ToList());
        }

        //below method will clear the whole shopping cart
        public void ClearCart()
        {
            //first get all the items from the database which belongs to the shopping cart id
            var cartItems = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId);

            //then remove those items from the cart
            _appDbContext.ShoppingCartItems.RemoveRange(cartItems);
            _appDbContext.SaveChanges();
        }

        //below method will calculate the total of all items added to the cart
        public decimal GetShoppingCartTotal()
        {
            //goes to the shopping cart dataset and retrieve all the items in that shopping cart Id 
            //then calculate the sum as in the below equation
            var total = _appDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Item.Price * c.Amount).Sum();

            return total;
        }

    }
}
