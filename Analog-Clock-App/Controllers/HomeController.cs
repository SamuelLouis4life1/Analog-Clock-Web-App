using Analog_Clock_App.Models;
using Analog_Clock_App.Models.ViewModels;
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

        public IActionResult Index([FromQuery] string clock)
        {
            if (!string.IsNullOrEmpty(clock))
            {
                HttpContext.Response.Cookies.Append(nameof(clock), clock);
            }

            var model = new HomeIndexViewModel()
            {
                Clock = !string.IsNullOrEmpty(clock) 
                    ? clock 
                    : Request.Cookies.Any(c => c.Key == nameof(clock))
                        ? Request.Cookies[nameof(clock)]
                        : "sun"
            };


            try
            {

            }
            catch (Exception ex)
            {

            }

            return View(model);
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
