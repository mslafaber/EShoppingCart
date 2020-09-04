using OnlineShopWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.ViewModels
{
    public class HomeViewModel
    {
        //folowwing property returns the Items on sale which is used in home controller to pass to the view.
        public IEnumerable<Item> ItemOnSale { get; set; }
    }
}
