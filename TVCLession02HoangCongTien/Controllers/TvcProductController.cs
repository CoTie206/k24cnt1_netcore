using Microsoft.AspNetCore.Mvc;
using TVCLession02HoangCongTien.Models;

namespace TVCLession02HoangCongTien.Controllers
{
    public class TvcProductController : Controller
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
            TvcProduct tvcProduct = new TvcProduct()
            {
                ProductId="P001",
                ProductName="Laptop Dell Vostro",
                YearRelease=2024,
                Price=12000000,
            };
            ViewData["productVD"] = tvcProduct;
            ViewBag.productVB = tvcProduct;
            return View();
        }
    }
}
