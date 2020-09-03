using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Models
{
    //Interface for Categories
    public interface ICategoryRepository
    {
        //Method to get all Categories
        IEnumerable<Category> GetAllCategories { get; }
    }
}
