using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnlineShopWebApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            //only to open the view and display the email address or any othet contact
            return View();
        }
    }
}
