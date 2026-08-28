using Microsoft.AspNetCore.Mvc;
using HctLession03.Models;
namespace HctLession03.Controllers
{
    public class HctProductController : Controller
    {
        // Tạo Mock data
        private readonly List<HctProduct> _products = new()
        {
            new HctProduct
            {
                HctProductId = "P001",
                HctProductName = "Canon EOS R50",
                HctYearRelease = "2023",
                HctPrice = 17990000
            },
            new HctProduct
            {
                HctProductId = "P002",
                HctProductName = "Sony Alpha A6400",
                HctYearRelease = "2019",
                HctPrice = 18990000
            },
            new HctProduct
            {
                HctProductId = "P003",
                HctProductName = "Nikon Z50",
                HctYearRelease = "2019",
                HctPrice = 21990000
            },
            new HctProduct
            {
                HctProductId = "P004",
                HctProductName = "Fujifilm X-S20",
                HctYearRelease = "2023",
                HctPrice = 32990000
            },
            new HctProduct
            {
                HctProductId = "P005",
                HctProductName = "Sony Alpha A7 IV",
                HctYearRelease = "2021",
                HctPrice = 48990000
            },
            new HctProduct
            {
                HctProductId = "P006",
                HctProductName = "Canon EOS R6 Mark II",
                HctYearRelease = "2022",
                HctPrice = 56990000
            },
            new HctProduct
            {
                HctProductId = "P007",
                HctProductName = "Nikon Z6 II",
                HctYearRelease = "2020",
                HctPrice = 41990000
            },
            new HctProduct
            {
                HctProductId = "P008",
                HctProductName = "Fujifilm X-T5",
                HctYearRelease = "2022",
                HctPrice = 38990000
            },
            new HctProduct
            {
                HctProductId = "P009",
                HctProductName = "Sony Alpha A7C II",
                HctYearRelease = "2023",
                HctPrice = 52990000
            },
            new HctProduct
            {
                HctProductId = "P010",
                HctProductName = "Canon EOS R10",
                HctYearRelease = "2022",
                HctPrice = 24990000
            }
        };
        public IActionResult Index()
        {
            return Json(_products);
        }

        //Get danh sách sản phẩm
        public IActionResult HctGetAllProduct()
        {
            ViewData["products"] = _products;
            return View();
        }
    }
}
