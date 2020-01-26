using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;


namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }
        public ActionResult NewMovie()
        {
            return View();
        }
        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }
        public IEnumerable<Movie> GetMovies()
        {
            var movies = _context.Movies.Include(c => c.Genre).ToList();
            return movies;
        }

        public ActionResult Random()
        {
            Movie movie = new Movie() { Name = "Shrek!" };
            List<Customer> customers = new List<Customer>
            {
                new Customer { Name = "Chris Catignani"},
                new Customer { Name = "Hazel Berger"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("movies/released/{yesr}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
    }
}