using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        //GET: Movies
        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }


        // GET: Movies/Random
        public ActionResult Random()
        {
            //Create a new movie
            var movie = new Movie() { Name = "Skrek!" };

            //Creates a new list of customers
            var customers = new List<Customer>
            {
                new Customer { Name = "John Smith" },
                new Customer { Name = "Jerry Seinfield"}
            };

            //Add the movie and list of customers to our RandomMovieViewModels object
            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };


            return View(viewModel);            
        }

        
        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        //public ActionResult Index( int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }

        //    if (String.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }

        //    return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        //}

        //GET: movies/released/
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek!" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }
    }
}