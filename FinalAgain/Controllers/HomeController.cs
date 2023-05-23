using Microsoft.AspNetCore.Mvc;

namespace FinalAgain.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
