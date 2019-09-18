using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application7.Models;

namespace Application7.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            Movie movie = new Movie() { Name = "Wenture" };

            return View(movie);
        }
    }
}