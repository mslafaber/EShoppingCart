using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShoppingCart.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }

        //These two properties will make the EF possible to understand the relation between Order and Order Detail
        public virtual Item Item { get; set; }
        public virtual Order Order { get; set; }
    }
}
