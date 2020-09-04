using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopWebApp.Models
{
    public class Order
    {
        //all the below properties show the information of the user

        [BindNever]
        public int OrderId { get; set; }

        [Required(ErrorMessage = "Please Enter Your First Name")]
        [Display(Name = "First Name")]
        [StringLength(30)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please Enter Your Last Name")]
        [Display(Name = "Last Name")]
        [StringLength(60)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please Enter Your Address")]
        [Display(Name = "Street Address")]
        [StringLength(150)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please Enter Your City Name")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please Enter Your State in Abbreviation Form")]
        [StringLength(3, MinimumLength = 2)]
        public string State { get; set; }

        [Required(ErrorMessage = "Please Enter Your Zip Code")]
        [StringLength(5, MinimumLength = 4)]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Required(ErrorMessage = "Please Enter Your Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        //Total amount due
        [BindNever]
        public decimal OrderTotal { get; set; }

        //Time when the order was created
        [BindNever]
        public DateTime OrderPlaced { get; set; }
    }
}
