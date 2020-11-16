using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieRegistration.Models;

namespace MovieRegistration.Controllers
{
    public class MovieRegistrationController : Controller
    {
        public IActionResult Index()
        {
            return View("MovieForm");
        }
        public IActionResult MovieRegistered(Movie m)
        {
            return View(m);
        }
        public IActionResult DisplayMovies(Movie m)
        {
            if(ModelState.IsValid)
            {
                return View();
            }
            else
            {
                return View("MovieForm", m);
            }
        }
    }
}
