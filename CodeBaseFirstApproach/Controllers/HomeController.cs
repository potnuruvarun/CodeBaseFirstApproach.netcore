using CodeBaseFirstApproach.Model.Models;
using CodeBaseFirstApproach.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CodeBaseFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        public   UserDbcontext userDbcontext;

        public HomeController(UserDbcontext user)
        {
            userDbcontext = user;
        }

        public IActionResult Index()
        {
            var data = userDbcontext.UserRegistration.ToList();
            return View(data);
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