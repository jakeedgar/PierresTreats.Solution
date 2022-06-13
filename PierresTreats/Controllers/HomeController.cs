using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PierresTreats.Models;

namespace PierresTreats.Controllers
{
    public class HomeController : Controller
    {
        private readonly PierresTreatsContext _db;
        // private readonly ILogger<HomeController> _logger;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }

        public HomeController(PierresTreatsContext db)
        {
            _db = db;
        }

        [HttpGet("/")]
        public IActionResult Index()
        {
            var flavors = _db.Flavors.ToList();
            var treats = _db.Treats.ToList();
            ViewBag.Flavors = flavors; 
            ViewBag.Treats = treats;
            return View();
        }

        public IActionResult Privacy()
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
