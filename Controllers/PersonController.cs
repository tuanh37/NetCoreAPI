namespace DemoMVC.Controllers
{
    using DemoMVC.Models;
    using Microsoft.AspNetCore.Mvc;
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
	    public IActionResult Index(Person ps)
	    {
	        string strOutput = "Xin chao " + ps.PersonId + "-" + ps.FullName + "-" + ps.Address;
	        ViewBag.infoPerson = strOutput;
	        return View();
        }
    }
}