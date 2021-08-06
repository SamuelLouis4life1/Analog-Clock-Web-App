using Analog_Clock_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Analog_Clock_App.Controllers
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

            ApplicationUser applicationUser = new ApplicationUser
            {
                DateTime =  DateTime.Now.ToString("MM/dd/yyyy hh:mm tt", System.Globalization.CultureInfo.InvariantCulture).ToUpper()                
            };

            var dataHoraLocal = DateTime.Now.ToString("MMMM, dd dddd, yyyy hh:mm tt").ToUpper();

            return View(applicationUser);
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
