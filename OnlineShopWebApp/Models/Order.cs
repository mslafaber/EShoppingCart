using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Models
{
    public class Order
    {
        //all the below properties show the information of the user
        public int OrderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }
        //Total amount due
        public decimal OrderTotal { get; set; }
        //Time when the order was created
        public DateTime OrderPlaced { get; set; }
    }
}
