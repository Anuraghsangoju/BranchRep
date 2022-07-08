using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HemanthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
