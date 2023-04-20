using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using ThirdTask_For_BackEnd___20._04._2023.DataAccess;
using ThirdTask_For_BackEnd___20._04._2023.Models;

namespace ThirdTask_For_BackEnd___20._04._2023.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View(Data.FeatureService);
        }

        public IActionResult Detail(int id)
        {
            FeatureForService FeatureService =Data.FeatureService.Find(x => x.Id == id);
            if (FeatureService == null)
            {
                return View("Error");
            }
            return View(FeatureService);
        }
    }
}
