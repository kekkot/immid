using Microsoft.AspNetCore.Mvc;

namespace immid.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
