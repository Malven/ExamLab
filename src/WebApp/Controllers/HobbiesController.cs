using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HobbiesController : Controller
    {
        private ApplicationDbContext _context;

        public HobbiesController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Hobbies
        public IActionResult Index(string searchString)
        {
            var hobbies = from h in _context.Hobby select h;

            if ( !string.IsNullOrEmpty( searchString ) ) {
                hobbies = hobbies.Where( x => x.Title.Contains( searchString ) );
            }
            return View(hobbies);
        }

        // GET: Hobbies/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Hobby hobby = _context.Hobby.Single(m => m.ID == id);
            if (hobby == null)
            {
                return HttpNotFound();
            }

            return View(hobby);
        }

        // GET: Hobbies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hobbies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Hobby hobby)
        {
            if (ModelState.IsValid)
            {
                _context.Hobby.Add(hobby);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hobby);
        }

        // GET: Hobbies/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Hobby hobby = _context.Hobby.Single(m => m.ID == id);
            if (hobby == null)
            {
                return HttpNotFound();
            }
            return View(hobby);
        }

        // POST: Hobbies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Hobby hobby)
        {
            if (ModelState.IsValid)
            {
                _context.Update(hobby);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hobby);
        }

        // GET: Hobbies/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Hobby hobby = _context.Hobby.Single(m => m.ID == id);
            if (hobby == null)
            {
                return HttpNotFound();
            }

            return View(hobby);
        }

        // POST: Hobbies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            Hobby hobby = _context.Hobby.Single(m => m.ID == id);
            _context.Hobby.Remove(hobby);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
