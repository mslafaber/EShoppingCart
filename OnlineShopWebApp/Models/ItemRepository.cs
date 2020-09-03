using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Models
{
    public class ItemRepository : IItemRepository
    {
        //Use AppDbContext to get the db data
        private readonly AppDbContext _appDbContext;

        //to use the above field inject it to a constructor as shown below
        public ItemRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        //method to get the Items from the dbset through the appDbContext
        public IEnumerable<Item> GetAllItems
        {
            get 
            {
                return _appDbContext.Items.Include(c => c.Category);
            }
        }

        //Method to get all the items and all the categories each of the items but only the ones which are on sale
        public IEnumerable<Item> GetItemsOnSale 
        {
            get
            {
                return _appDbContext.Items.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        //below method will filter the Item that matches the Id by getting all items and matching the id through the dbset
        public Item GetItemById(int itemId)
        {
            return _appDbContext.Items.FirstOrDefault(c => c.ItemId == itemId);
        }
    }
}