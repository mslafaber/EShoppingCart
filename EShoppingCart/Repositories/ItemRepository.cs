using EShoppingCart.Data;
using EShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShoppingCart.Models;
using Microsoft.EntityFrameworkCore;

namespace EShoppingCart.Repositories
{
    //This repository will inherit from IItemRepository(The interface which holds the required for this repository)
    public class ItemRepository:IItemRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        //Below constructor in this repository is used to inject the ApplicationDbContext service to interact with the database
        public ItemRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //Added relenat properties as shown below
        public IEnumerable<Item> Items => _applicationDbContext.Items.Include(c => c.Category);

        public IEnumerable<Item> PreferredItems => _applicationDbContext.Items.Where(p => p.IsPrefferedItem).Include(c => c.Category);

        public Item GetItemById(int itemId) => _applicationDbContext.Items.FirstOrDefault(p => p.ItemId == itemId);
    }
}
