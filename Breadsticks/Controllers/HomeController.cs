using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Breadsticks.Models;

namespace Breadsticks.Controllers
{
    public class HomeController : Controller
    {
        //TESTING DATA
        private static User user = new User(
            new List<Account>()
            {
                new Cash(initBalance: 401.00m),
                new CreditCard("Chase Freedom Unlimited", -2586.99m),
                new CreditCard("Chase Sapphire Reserve", -109.52m),
                new Bank("Ally", 8032.59m),
                new Bank("Charles Schwab", 17.88m),
                new Bank("Chase", 2937.87m)
            }
        );
        

        public IActionResult Index()
        {
            ViewData["User"] = user;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
