using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mudanza1711.Controllers
{
    public class AdminController : Controller
    {
        public string Index()
        {
            return "This is my default action...";
        }
        public IActionResult Camiones()
        {
            return View();
        }
    }
}