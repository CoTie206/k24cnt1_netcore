using Microsoft.AspNetCore.Mvc;

namespace HctLession13Layout.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Search(string keyword)
        {
            // Implement search logic here
            ViewData["Keyword"] = keyword;
            return View();
        }
        public IActionResult Hots()
        {
            // Implement logic to get hot products here
            return View();
        }
    }
}
