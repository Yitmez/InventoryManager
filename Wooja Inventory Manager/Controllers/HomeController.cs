using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Wooja_Inventory_Manager.Models;
using Wooja_Inventory_Manager.Services;

namespace Wooja_Inventory_Manager.Controllers
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
        public IActionResult Settings()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Math(int x, int y)
        {
            // int result = x + y;
            MathService mathService = new MathService();
            
            return View(mathService.MathAddition(x, y));
        }
        public IActionResult Dashboard()
        {
            return View();
        }
       
        [HttpPost]
        public IActionResult Editor(Category category, Brand brand, string name)
        { 
            Item item = new Item() { Name = name, Brand = brand };
         
            // tempContext.Tiere.Add(angelegtesTier);
            // tempContext.SaveChanges();
            return View();
        }

        [HttpGet]     // editor ohne parameter
        public IActionResult Editor()
        {

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
