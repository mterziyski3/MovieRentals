using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext context;

        public MoviesController()
        {
            context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult New()
        {
            var viewModel = new MovieFormViewModel()
            {
                Genres = context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModelForForm = new MovieFormViewModel(movie)
                {
                    Genres = context.Genres.ToList()
                };
                return View("MovieForm", viewModelForForm);
            }

            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Today;

                context.Movies.Add(movie);
            }

            else
            {
                var movieInDB = context.Movies.SingleOrDefault(m => m.Id == movie.Id);

                movieInDB.Name = movie.Name;
                movieInDB.GenreId = movie.GenreId;
                movieInDB.ReleaseDate = movie.ReleaseDate;
                movieInDB.numberInStock = movie.numberInStock;
            }

            context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult Edit(int id)
        {
            var movieInDB = context.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDB == null)
                return HttpNotFound();

            MovieFormViewModel viewModel = new MovieFormViewModel(movieInDB)
            {             
                Genres = context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }
        // GET: Movies
        public ActionResult Index()
        {
            //var movies = context.Movies.Include(c => c.Genre);

            if (User.IsInRole("CanManageMovies"))
            {
                return View("IndexAdmin");
            }

            return View("IndexGuest");
        }

        public ActionResult Details(int id)
        {
            var movie = context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            }

            else
            {
                return View(movie);
            }
        }
    }
}