using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MovieRegistration.Controllers
{
    public class DisplayMoviesController : Controller
    {
        public IActionResult Index()
        {
            return View("DisplayMovies");
        }
    }
}
