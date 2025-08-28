using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class Bai1Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(); // => Views/Bai1/Index.cshtml
        }

        [HttpPost]
        public IActionResult Index(Bai1 model)
        {
            return View("Result", model); // => Views/Bai1/Result.cshtml
        }
    }
}
