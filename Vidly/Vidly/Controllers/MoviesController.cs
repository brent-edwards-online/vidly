using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            var movie = new Movie();
            movie.Id = 0;
            movie.Name = "Bob the Builder";
            return View(movie);
        }
    }
}
