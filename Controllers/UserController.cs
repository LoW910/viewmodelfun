using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class UserController : Controller
    {
        [HttpGet("user")]
        public IActionResult Person(){
            User newPerson =  new User("tim","tom");
            return View(newPerson);
        }
    }
}