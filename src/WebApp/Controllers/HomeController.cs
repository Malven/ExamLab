using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebApp.Models;
using WebApp.Strategies;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController( ApplicationDbContext context ) {
            _context = context;
        }

        public IActionResult Index()
        {
            var hobbies = from h in _context.Hobby select h;
            
            IQueryable<Hobby> hobbyToShow = HobbyFactory.GetHobbyStrategy().GetHobby( hobbies );

            return View(hobbyToShow);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
