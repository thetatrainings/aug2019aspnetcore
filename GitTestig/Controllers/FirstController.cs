using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GitTestig.Controllers
{
    public class FirstController : Controller
    {
        int a,b;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
             a = 10;
            b=200019091;
            return View();
        }
    }
}