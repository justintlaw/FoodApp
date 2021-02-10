using FoodApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FoodApp.Controllers
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
            // send a list of top shops to the view
            List<Shop> topShops = new List<Shop>();
            return View(Shop.GetTopShops());
        }

        [HttpGet]
        public IActionResult Suggestion()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Suggestion(Suggestion response)
        {
            if (ModelState.IsValid)
            {
                // add a suggestion if valid
                ViewBag.Message = "Suggestion successfully submitted.";
                Storage.addShop(response);
            }
            else
            {
                ViewBag.Message = "One or more inputs were invalid. Try using ###-###-#### for phone number.";
            }

            return View("Confirmation");
        }

        public IActionResult ListSuggestions()
        {
            return View(Storage.Suggestions);
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
