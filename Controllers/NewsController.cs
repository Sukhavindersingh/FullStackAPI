using Microsoft.AspNetCore.Mvc;

namespace FullStackAPI.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
