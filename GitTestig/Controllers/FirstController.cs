using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GitTestig.Controllers
{
    public class FirstController : Controller
    {
        int a;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
             a = 10;
            return View();
        }

        public IActionResult Abubakar()
        {
            a = 10;
            return View();
        }

    }
}