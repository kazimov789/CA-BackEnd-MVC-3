using Microsoft.AspNetCore.Mvc;
using ThirdTask_For_BackEnd___20._04._2023.DataAccess;
using ThirdTask_For_BackEnd___20._04._2023.ModelView;

namespace ThirdTask_For_BackEnd___20._04._2023.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           HomeModelView homeModelView = new HomeModelView();
            homeModelView.ServiceFeature = Data.FeatureService;
            homeModelView.HomeFeature = Data.FeatureHome;
            return View(homeModelView);
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
