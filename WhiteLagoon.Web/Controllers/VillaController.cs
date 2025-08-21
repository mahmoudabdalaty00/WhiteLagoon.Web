using Microsoft.AspNetCore.Mvc;
using WhiteLagoon.Application.common.interfaces;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;

namespace WhiteLagoon.Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly IVillaRepository _db;

        public VillaController(IVillaRepository db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var villas = _db.GetAll();
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
                _db.Add(villa);
                _db.Save();
                TempData["success"] = "Villa Created Successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(villa);
        }

        public IActionResult Update(int villaId)
        {
            var villa = _db
                 .Get(a => a.Id == villaId);
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
                _db.Update(villa);
                _db.Save();
                TempData["success"] = "Villa Update Successfully";

                return RedirectToAction(nameof(Index));
            }

            return View(villa);
        }

         public IActionResult Delete(int villaId)
        {
            var villa = _db    
                 .Get(a => a.Id == villaId);
            if (villa == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(villa);
        }


        [HttpPost]
        public IActionResult Delete(Villa villa)
        {
          
            
            var villaobj = _db
                 .Get(a => a.Id == villa.Id);

            if (villaobj is not null)
            {
                _db.Delete(villaobj.Id);
                _db.Save();
                TempData["success"] = "Villa Deleted Successfully";

                return RedirectToAction(nameof(Index));
            }

            return View(villa);
        }
    }
}
