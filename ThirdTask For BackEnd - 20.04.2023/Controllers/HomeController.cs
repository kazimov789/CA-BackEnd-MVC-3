using Microsoft.AspNetCore.Mvc;
using ThirdTask_For_BackEnd___20._04._2023.DataAccess;
using ThirdTask_For_BackEnd___20._04._2023.ModelView;

namespace ThirdTask_For_BackEnd___20._04._2023.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
           //HomeModelView homeModelView = new HomeModelView();
           // homeModelView.ServiceFeature = _context.FeatureForService;
           // homeModelView.HomeFeature = _context.FeatureForHome;
           // homeModelView.Slider = _context.Slider;
            return View(_context);
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
