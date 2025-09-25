using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class TestController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(); // => Views/Test/Index.cshtml
        }

        [HttpPost]
        public IActionResult Index(Test model)
        {
            return View("Result", model); // => Views/Test/Result.cshtml
        }
    }

}


    



