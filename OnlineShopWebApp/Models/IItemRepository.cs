using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Models
{
    //Interface for Items
    public interface IItemRepository
    {
        //Method to get all the Items
        IEnumerable<Item> GetAllItems { get; }

        //Method to get all the Items that is on sale
        IEnumerable<Item> GetItemsOnSale { get; }

        //Method to get a single Item which matches to the ID that is passed to the URL
        Item GetItemById(int itemId);
    }
}
