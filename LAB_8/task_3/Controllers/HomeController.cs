using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using task_3.Models;

namespace task_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult test1()
        {
            ViewBag.number1 = 5;
            ViewBag.number2 = 6;
            ViewBag.sum = ViewBag.number1 + ViewBag.number2;
            return View();
        }
        public IActionResult test2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult show_ans(IFormCollection fc)
        {
           ViewBag.number1 = fc["number1"].ToString();
           ViewBag.number2 = fc["number2"].ToString();
           ViewBag.sum = int.Parse(ViewBag.number1) + int.Parse(ViewBag.number2);

            return View("show_ans");
        }

        public IActionResult test3()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
