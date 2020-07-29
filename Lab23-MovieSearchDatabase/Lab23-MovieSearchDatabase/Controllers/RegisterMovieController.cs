using Lab23_MovieSearchDatabase.Data;
using Lab23_MovieSearchDatabase.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab23_MovieSearchDatabase.Controllers
{
    public class RegisterMovieController : Controller
    {
        private DB_Context _context;

        public RegisterMovieController(DB_Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            _context.Movies.Add(movie);
            _context.SaveChanges();

            return View(movie);
        }
    }
}
