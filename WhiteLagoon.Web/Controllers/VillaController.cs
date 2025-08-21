using Microsoft.AspNetCore.Mvc;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;

namespace WhiteLagoon.Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly AppDbContext _db;

        public VillaController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var villas = _db.Villas.ToList();
            return View(villas);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Villa villa)
        {
            if (ModelState.IsValid)
            {
                _db.Villas.Add(villa);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(villa);
        }

        public IActionResult Update(int villaId)
        {
            var villa = _db.Villas
                 .FirstOrDefault(a => a.Id == villaId);
            if (villa == null)
            {
                return RedirectToAction("Error","Home");
            }
            return View(villa);
        }

        [HttpPost]
        public IActionResult Update(Villa villa)
        {
            if (ModelState.IsValid)
            {
                _db.Villas.Update(villa);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(villa);
        }

         public IActionResult Delete(int villaId)
        {
            var villa = _db.Villas
                 .FirstOrDefault(a => a.Id == villaId);
            if (villa == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(villa);
        }


        [HttpPost]
        public IActionResult Delete(Villa villa)
        {
          
            
            var villaobj = _db.Villas
                 .FirstOrDefault(a => a.Id == villa.Id);

            if (villaobj is not null)
            {
                _db.Villas.Remove(villaobj);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(villa);
        }
    }
}
