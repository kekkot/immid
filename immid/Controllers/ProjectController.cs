using Microsoft.AspNetCore.Mvc;

namespace immid.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
