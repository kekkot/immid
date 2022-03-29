using Microsoft.AspNetCore.Mvc;

namespace immid.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }
    }
}
