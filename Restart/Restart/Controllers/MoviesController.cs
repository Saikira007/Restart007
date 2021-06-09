using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Restart.Models;
using Restart.ViewModels;


namespace Restart.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            return View();

        }

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer>()
            {
                new Customer{Id= 101, Name="Saikiran" },
                 new Customer{Id= 102, Name="Challa" },
                  new Customer{Id= 103, Name="Hello" }
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers,
            };

            return View(viewModel);

        }


        [Route("movies/released/{year}/{month}")]
        public ActionResult ReleaseByDate(int year,int month)
        {
            return Content(year + "/" + month);
        }

    }
}