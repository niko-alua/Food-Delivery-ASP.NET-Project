using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult CurrentOrders()
        {
            return View();
        }
    }
}
