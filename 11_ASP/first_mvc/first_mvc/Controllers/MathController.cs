using Microsoft.AspNetCore.Mvc;

namespace first_mvc.Controllers
{
    public class MathController : Controller
    {
        public MathController()
        {
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
