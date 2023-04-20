using Microsoft.AspNetCore.Mvc;
using ThirdTask_For_BackEnd___20._04._2023.DataAccess;

namespace ThirdTask_For_BackEnd___20._04._2023.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View(Data.FeatureService);
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}
