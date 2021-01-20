using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DPL.Template.Client.Web.Models;
using DPL.Template.Managers;

namespace DPL.Template.Client.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITestManager _testManager;

        public HomeController(ITestManager testManager)
        {
            _testManager = testManager;
        }

        public IActionResult Index()
        {
            // Test call
            var response = _testManager.TestMe("hi");

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
