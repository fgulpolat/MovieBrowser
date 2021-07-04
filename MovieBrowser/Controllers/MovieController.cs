using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MovieBrowser.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Lİst()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }
    }
}