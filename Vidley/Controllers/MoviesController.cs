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
        // GET: Movies/Random
        public ActionResult Random()
        {

            var movie = new Movie()
            {
                Name = "Shrek!"
            };

            var Customers = new List<Customer>
            {

                new Customer { Name= "Customer 1"},
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = Customers

            };
            return View(viewModel);
        }


        /*
        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year+"/"+month);
        }
    
        */
        }
}