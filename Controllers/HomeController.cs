using Microsoft.AspNetCore.Mvc;

namespace FullStackAPI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
