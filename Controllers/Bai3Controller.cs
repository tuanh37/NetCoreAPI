using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class Bai3Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(Bai3 model)
        {
            if (model.ChieuCao <= 0)
            {
                model.PhanLoai = "Chiều cao phải lớn hơn 0.";
                return View(model);
            }

            model.BMI = model.CanNang / (model.ChieuCao * model.ChieuCao);

            if (model.BMI < 18.5)
                model.PhanLoai = "Gầy";
            else if (model.BMI < 25)
                model.PhanLoai = "Bình thường";
            else if (model.BMI < 30)
                model.PhanLoai = "Thừa cân";
            else
                model.PhanLoai = "Béo phì";

            return View(model);
        }
    }
}
