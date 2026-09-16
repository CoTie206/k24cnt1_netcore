using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HctLesson08Models.Models;

namespace HctLesson08Models.Controllers
{
    public class HctHomeController : Controller
    {
        private readonly ILogger<HctHomeController> _logger;

        public HctHomeController(ILogger<HctHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult HctIndex()
        {
            return View();
        }

        public IActionResult HctPrivacy()
        {
            return View();
        }

        public IActionResult HctAbout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
