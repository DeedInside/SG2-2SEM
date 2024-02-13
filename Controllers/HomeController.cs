using Microsoft.AspNetCore.Mvc;

namespace SG2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Short()
        {
            return View();
        }
    }
}
