using Microsoft.AspNetCore.Mvc;

namespace immid.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
