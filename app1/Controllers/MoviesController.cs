using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using app1.Models;
using app1.ViewModels;

namespace app1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        private DBmodel db;
        public MoviesController() {
            db = new DBmodel();
        }
        protected override void Dispose(bool disposing)
        {
            db.Dispose();
        }
        public ActionResult Random()
        {

            var movie = new Movie()
            {
                Name = "Shrek"
            };            
            var customers = new List<Customer>
            {
                new Customer{Name = "Ali"},
                new Customer{Name="Mehdi"}
            };           
            var viewdata = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };            
            return View(viewdata);
            //return Content("Hello World");
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
            //return new EmptyResult();
        }
        public ActionResult definite()
        {
            var movie = new Movie()
            {
                Name = "It is definite"
            };
            return View(movie);
        }
        public ActionResult edit(int movieId)  // note the name of the param as the default name set in the RouteConfig
        {
            return Content("id = " + movieId);
        }
        // As it is specified in the routeconfig it is the default action 
        public ActionResult Index(int? pageIndex, String sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("page index={0} & sortBy= {1}", pageIndex, sortBy));
        }
        [Route("Movies/Release/{year}/{month:regex(\\d{2}):range(1,12)}")] // you can use as many constraints as you like
        public ActionResult ByReleaseDate(int year , int month)
        {
            return Content(year + "/" + month);
        }
    }
}