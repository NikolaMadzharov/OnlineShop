using Microsoft.AspNetCore.Mvc;

namespace MyWebProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
