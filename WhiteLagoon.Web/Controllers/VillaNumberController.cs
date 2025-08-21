using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;
using WhiteLagoon.Web.ModelVM;

namespace WhiteLagoon.Web.Controllers
{
    public class VillaNumberController : Controller
    {
        private readonly AppDbContext _db;

        public VillaNumberController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var villas = _db.VillaNumbers
                .Include(v => v.Villa)
                .ToList();
            return View(villas);
        }

        [HttpGet]
        public IActionResult Create()
        {
            VillaNumberVM v = new()
            {
                villaList = _db.Villas.ToList()
                     .Select(u => new SelectListItem
                     {
                         Text = u.Name,
                         Value = u.Id.ToString()
                     }),
                villaNumber = new()
            };



            return View(v);
        }

        [HttpPost]
        public IActionResult Create(VillaNumberVM villa)
        {
            VillaNumber nu = villa.villaNumber;
            if (ModelState.IsValid)
            {
                _db.VillaNumbers.Add(nu);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            VillaNumberVM v = new()
            {
                villaList = _db.Villas.ToList()
                .Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                villaNumber = nu
            };
            return View(v);
        }



        public IActionResult Update(int villaId)
        {
            var villa = _db.VillaNumbers
                 .FirstOrDefault(a => a.Villa_Number == villaId);
            if (villa == null)
            {
                return RedirectToAction("Error", "Home");
            }
            VillaNumberVM v = new()
            {
                villaList = _db.Villas.ToList()
                .Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                villaNumber = villa
            };
            return View(v);
        }

        [HttpPost]
        public IActionResult Update(VillaNumberVM villa)
        {
            if (ModelState.IsValid)
            {
                _db.VillaNumbers.Update(villa.villaNumber);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                        VillaNumberVM v = new()
                {
                    villaList = _db.Villas.ToList()
                           .Select(u => new SelectListItem
                           {
                               Text = u.Name,
                               Value = u.Id.ToString()
                           }),
                    villaNumber = villa.villaNumber
                };
            return View(v);
            }
               
        }

        public IActionResult Delete(int villaId)
        {
            var villa = _db.VillaNumbers
                .Include(v => v.Villa)
                 .FirstOrDefault(a => a.Villa_Number == villaId);
            if (villa == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(villa);
        }


        [HttpPost]
        public IActionResult Delete(VillaNumber villa)
        {


            var villaobj = _db.VillaNumbers
                 .FirstOrDefault(a => a.Villa_Number == villa.Villa_Number);

            if (villaobj is not null)
            {
                _db.VillaNumbers.Remove(villaobj);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
         
            return View(villa);
        }
    }
}
