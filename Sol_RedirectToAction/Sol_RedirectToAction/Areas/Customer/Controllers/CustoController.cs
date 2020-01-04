using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sol_RedirectToAction.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CustoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}