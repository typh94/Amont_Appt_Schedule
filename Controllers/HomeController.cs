using System;
using System.Diagnostics;
using Amont_APPT.Models;
using Microsoft.AspNetCore.Mvc;

namespace Amont_APPT.Controllers
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

        public IActionResult Technicien()
        {
            return View();
        }
        public IActionResult Manager()
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
