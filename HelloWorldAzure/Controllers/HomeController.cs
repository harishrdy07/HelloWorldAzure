using HelloWorldAzure.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelloWorldAzure.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Testing()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Tv1()
        {
            return View();
        }
        public IActionResult Washing1()
        {
            return View();
        }
        public IActionResult Calc()
        {
            return View();
        }
        public IActionResult OneMore()
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
