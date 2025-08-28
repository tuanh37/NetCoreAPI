using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class Bai2Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(Bai2 model)
        {
            double kq = 0;
            string ketQua;

            switch (model.PhepTinh)
            {
                case "cong":
                    kq = model.SoA + model.SoB;
                    ketQua = $"{model.SoA} + {model.SoB} = {kq}";
                    break;
                case "tru":
                    kq = model.SoA - model.SoB;
                    ketQua = $"{model.SoA} - {model.SoB} = {kq}";
                    break;
                case "nhan":
                    kq = model.SoA * model.SoB;
                    ketQua = $"{model.SoA} × {model.SoB} = {kq}";
                    break;
                case "chia":
                    if (model.SoB == 0)
                        ketQua = "Không thể chia cho 0.";
                    else
                    {
                        kq = model.SoA / model.SoB;
                        ketQua = $"{model.SoA} ÷ {model.SoB} = {kq}";
                    }
                    break;
                default:
                    ketQua = "Phép tính không hợp lệ.";
                    break;
            }

            model.KetQua = ketQua;
            return View(model);
        }
    }
}
