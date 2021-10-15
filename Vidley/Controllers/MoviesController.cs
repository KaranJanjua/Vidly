using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidley.Models;
using Vidley.ViewModels;

namespace Vidley.Controllers
{
    public class MoviesController : Controller
    {

        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id=1, Name="Matrix"},
                new Movie { Id=2, Name="Hobbits"}
            };
        }

        public ViewResult MoviesList()
        {

            var movies = GetMovies();
            return View(movies);
        }
        /*
        // GET: Movies/Random
        public ActionResult Random()
        {

            var movie = new Movie()
            {
                Name = "Matrix: Reloaded"
            };

            var Customers = new List<Customer>
            {

                new Customer { Name = "Karanbir Janjua"},
                new Customer { Name = "Jaikirat Sandhu" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = Customers

            };
            return View(viewModel);
        }
        public ActionResult Index(int? pageIndex, string sortby)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortby)) { sortby = "Name"; }

            return Content(String.Format("PageIndex={0}&sortby={1}",pageIndex,sortby));
        }
        */
        //route[""]
        public ActionResult ByReleaseDate(int year, int month) {

            return Content(year+"/"+month);
        }

        }
}