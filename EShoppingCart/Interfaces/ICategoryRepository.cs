using EShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShoppingCart.Interfaces
{
    public interface ICategoryRepository
    {
        //This property is used to hold all categories.
        IEnumerable<Category> Categories { get; }
    }
}
