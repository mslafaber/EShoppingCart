using EShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShoppingCart.Interfaces
{
    interface IItemRepository
    {
        //This first property will get all the Items
        IEnumerable<Item> Items { get; }
        //The below second property is used to get all preferred Items which will be shown in the front page of the EShoppinCart application
        IEnumerable<Item> PreferredItems { get; }
        //Below method is used to get the relevant Item by its Id
        Item GetItemById(int itemId);

    }
}
