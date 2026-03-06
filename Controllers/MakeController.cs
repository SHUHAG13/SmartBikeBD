using Microsoft.AspNetCore.Mvc;
using SmartBikeBD.Data;
using SmartBikeBD.Models;


namespace SmartBikeBD.Controllers
{
    public class MakeController : Controller
    {
        private readonly AppDbContext _context;
        public MakeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var makes = _context.Makes.ToList();
            return View(makes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Make make)
        {
            if (ModelState.IsValid)
            {
                _context.Makes.Add(make);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(make);
        }


        public IActionResult Edit(int id)
        {
            var make= _context.Makes.Find(id);
           if(make==null)
            {
                return NotFound();
            }
            return View(make);
        }

        [HttpPost]
        public IActionResult Edit(Make make)
        {
            if (ModelState.IsValid)
            {
                _context.Makes.Update(make);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));

            }
            return View(make);

        }

        public IActionResult Delete(int id)
        {
            var make =_context.Makes.Find(id);
            if(make==null)
            {
                return NotFound();
            }
            return View(make);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var make = _context.Makes.Find(id);
            if (make == null)
            {
                return NotFound();
            }
            _context.Makes.Remove(make);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
