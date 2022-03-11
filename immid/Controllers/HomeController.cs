using immid.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace immid.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        ProjectContext db;
        //В конструкторе получаем контекст данных
        public HomeController(ILogger<HomeController> logger, ProjectContext context)
        {
            _logger = logger;
            db = context;
        }
        //Вызываем метод для генерации представления
        //В него передает все объекты из таблицы Projects
        public IActionResult Index()
        {
            return View(db.Projects.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}