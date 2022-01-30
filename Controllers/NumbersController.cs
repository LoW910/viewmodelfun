using Microsoft.AspNetCore.Mvc;

namespace ViewModelFun.Controllers
{
    public class NumbersController : Controller{
        
        [HttpGet("numbers")]
        public IActionResult Numbers() {
            int[] nums = new int[]{
                1,
                4,
                7,
                9,
                420,
                69
            };

            return View(nums);
        }
    }
}