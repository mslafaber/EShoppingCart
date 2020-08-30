using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShoppingCart.Models
{
    public class Category
    {
        //Identifier of the category model is category ID
        public int CategoryId { get; set; }
        //Category Name will hold the category name like Electric Items,Clothing Items,Shoes etc.
        public string CategoryName { get; set; }
        public string Description { get; set; }
        //The list property below will make the one to many relationship between the Category and Item Models
        public List<Item> Items { get; set; }
    }
}
