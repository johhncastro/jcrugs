using Microsoft.AspNetCore.Mvc;

namespace jcruggy.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
