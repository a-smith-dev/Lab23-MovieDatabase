using System.Linq;
using Lab23_MovieSearchDatabase.Data;
using Lab23_MovieSearchDatabase.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab23_MovieSearchDatabase.Controllers
{
    public class SearchController : Controller
    {
        private SearchResult _listOfMovies;

        public SearchController(DB_Context context)
        {
            _listOfMovies = new SearchResult();
            foreach (var movie in context.Movies.ToList())
            {
                _listOfMovies.MovieList.Add(movie);
            }

            _listOfMovies.MovieList = _listOfMovies.MovieList.OrderBy(x => x.Title).ToList();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SearchResultTitle(SearchRequest request, string title)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            _listOfMovies.SearchTitle(title);

            return View(_listOfMovies);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SearchResultGenre(string genre)
        {
            _listOfMovies.SearchGenre(genre);

            return View(_listOfMovies);
        }
    }
}
