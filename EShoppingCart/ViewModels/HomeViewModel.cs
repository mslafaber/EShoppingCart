using EShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShoppingCart.ViewModels
{
    public class HomeViewModel
    {
        //this will display only the preffered Items
        public IEnumerable<Item> PreferredItems { get; set; }
    }
}
