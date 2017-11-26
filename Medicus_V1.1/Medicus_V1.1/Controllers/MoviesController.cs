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
    }
}