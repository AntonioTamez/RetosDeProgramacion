using _32_SegundoNumeroMasGrande.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _32_SegundoNumeroMasGrande.Controllers
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

            List<int> list = new List<int>() { 1,3,43,5,7,9,59,11,13};


            var secondBigest = list.OrderByDescending(c => c).Skip(1).FirstOrDefault();




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