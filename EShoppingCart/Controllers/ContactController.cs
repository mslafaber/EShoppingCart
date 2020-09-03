using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EShoppingCart.Controllers
{
    public class ContactController : Controller
    {
        //returns a view
        public ViewResult Index()
        {
            return View();
        }
    }
}
