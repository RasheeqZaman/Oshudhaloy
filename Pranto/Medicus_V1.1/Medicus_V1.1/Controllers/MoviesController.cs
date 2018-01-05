using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Medicus_V1._1.Models;

namespace Medicus_V1._1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { name = "Toy Story" };
            return View(movie);
        }

        public ActionResult Edit(int moviesID)
        {
            return Content("id="+moviesID);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "name";
            }
            return Content(String.Format("pageindex={0},sortBy={1}", pageIndex, sortBy));
        }
    }
}