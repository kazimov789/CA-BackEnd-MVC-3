using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using ThirdTask_For_BackEnd___20._04._2023.DataAccess;
using ThirdTask_For_BackEnd___20._04._2023.Models;

namespace ThirdTask_For_BackEnd___20._04._2023.Controllers
{
    public class ServiceController : Controller
    {
        private readonly DataContext _context;
        public ServiceController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<FeatureForService> ftservice = _context.FeatureForService.ToList();
            return View(ftservice);
        }

        public IActionResult Detail(int id)
        {
            FeatureForService FeatureService = _context.FeatureForService.ToList().Find(x => x.Id == id);
            if (FeatureService == null)
            {
                return View("Error");
            }
            return View(FeatureService);
        }
    }
}
