using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TeddyBear.Models;
using TeddyBear.Repository;

namespace TeddyBear.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.lstCateOfProductOutstand = HomeRepo.GetCateOfProductOutstand();
            ViewBag.testGit = "abc";
            return View();
        }

        public IActionResult Privacy()
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
