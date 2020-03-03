using Main_Site.Models;
using MainSite.AppCode.Infrastructure;
using MainSite.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Main_Site.Controllers
{
    public class HomeController : Controller
    {
        readonly IRepository<Setting> settingRepo;
        public HomeController(IRepository<Setting> settingRepo)
        {
            this.settingRepo = settingRepo;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
