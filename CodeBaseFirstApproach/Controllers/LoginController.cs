using Microsoft.AspNetCore.Mvc;

namespace CodeBaseFirstApproach.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
