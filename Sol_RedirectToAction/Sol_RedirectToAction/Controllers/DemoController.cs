using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Sol_RedirectToAction.Controllers
{
    public class DemoController : Controller
    {

        [BindProperty(SupportsGet =true)]
        public int id { get; set; }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OnTest1()
        {
            return View("Index");
        }


        public IActionResult OnTest()
        {
            // Redirect To Action : Call same action on same controller
            //return RedirectToAction("Index");

            // Redirect To Action With Parameter
            //return RedirectToAction("OnTest1", new { id = 1 });

            //Redirect To Action on Different Controller
            //return RedirectToAction("Index", "Home");

            // Redirect To Action with Area
            return RedirectToAction("Index", "Custo", new { Area = "Customer" });
        }
    }
}