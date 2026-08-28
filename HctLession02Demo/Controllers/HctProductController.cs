using Microsoft.AspNetCore.Mvc;
using HctLession02Demo.Models;

namespace HctLession02Demo.Controllers
{
    public class HctProductController : Controller
    {
        public IActionResult Index()
        {
            // đưa dữ liệu ra view

            ViewBag.name = "Hoàng Công Tiên";
            ViewData["address"] = "Fit NTU";
            TempData["UNI"] = "Trường Đại Học Nguyễn Trãi";

            return View();
        }
        // Chi tiết sản phẩm
        public IActionResult GetProduct()
        {
            //Mock data
            HctProduct hctProduct = new HctProduct()
            {
                ProductId="P001",
                ProductName="Laptop Dell Vostro",
                YearRelease=2024,
                Price=12000000,
            };
            ViewData["productVD"] = hctProduct;
            ViewBag.productVB = hctProduct;
            return View();
        }
    }
}
