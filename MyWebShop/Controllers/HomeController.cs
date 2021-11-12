using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWebShop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebShop.Controllers
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

        public IActionResult ShowProduct(ProductTypes? id)
        {
            Product product = null;
            switch(id)
            {
                case ProductTypes.Car:
                    product = new Car { Name = "Audi R8 Spyder", Speed = 322, UnitPrice = 239.405M };
                    return View("Car", product);
                case ProductTypes.Drink:
                    product = new Drink { Name = "Fanta", ContainsAlcohol = false, UnitPrice = 2.09M };
                    return View("Drink", product);
                case ProductTypes.Food:
                    product = new Food { Name = "Cheeseburger", Weight = 1.1, UnitPrice = 1.50M };
                    return View("Food", product);
            }
            return View(product);
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
