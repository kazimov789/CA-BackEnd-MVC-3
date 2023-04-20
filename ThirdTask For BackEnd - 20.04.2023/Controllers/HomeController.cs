using Microsoft.AspNetCore.Mvc;

namespace ThirdTask_For_BackEnd___20._04._2023.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
