﻿using System;
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
            int a=10;
            return View();
        }
        public IActionResult AboutUs()
        {
             a = 30;
            b=200019091;
            return View();
        }
        public IActionResult Master()
        {
            return View();
        }

        public IActionResult Abubakar()
        {
            a = 10;
            return View();
        }
        public IActionResult taimoor()
        {
            return View();
        }
    }
}