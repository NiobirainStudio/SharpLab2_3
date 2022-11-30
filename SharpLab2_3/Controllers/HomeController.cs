using Microsoft.AspNetCore.Mvc;
using SharpLab2_3.Models;
using System.Diagnostics;

using SharpLab2_3.DbData;

namespace SharpLab2_3.Controllers
{
    public class HomeController : Controller
    {
        // Database manager linking
        private readonly AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            _db.Artists.Add(new Artists { ArtistName = "Beeees"});
            _db.SaveChanges();
            return View();
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