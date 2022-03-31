using Microsoft.AspNetCore.Mvc;
using immid.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;


namespace immid.Controllers
{
    public class AdminController : Controller
    {
        private NewsContext db;
        public AdminController(NewsContext context)
        {
            db = context;
        }

        public IActionResult Home()
        {
            return Redirect("~/Auth/login");
        }

        [HttpGet]
        public IActionResult News()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> News(NewsModel model)
        {
            db.News.Add(new NewsModel { Title = model.Title, Desc = model.Desc, Text = model.Text, Category="ab" });
            await db.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}
