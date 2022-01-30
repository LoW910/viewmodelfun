using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet("names")]
        public IActionResult Names(){
            List<User> people = new List<User>{
                new User("jeb", "rose"),
                new User("Ian", "french"),
                new User("billy", "turtle"),
                new User("jayden", "lion"),
                new User("cari", "longhair")
            };
            return View(people);

        }

        [HttpGet("")]
        public IActionResult NewMessage(){
            
            string newMessage = "this is a message passed from the controler through the model into the viewmodel";
            return View("index",newMessage);
        }
    }
}
