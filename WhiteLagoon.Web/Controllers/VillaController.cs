using Microsoft.AspNetCore.Mvc;
using System;
using WhiteLagoon.Application.common.interfaces;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly IUnitOfWork _db;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public VillaController(IUnitOfWork db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var villas = _db.VillaRepository.GetAll();
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

                if (villa.Image != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(villa.Image.FileName);
                    string imagePath = Path.Combine(_webHostEnvironment.WebRootPath, @"images\Villa");

                    using (var fileStream = new FileStream(Path.Combine(imagePath, fileName), FileMode.Create))
                    {
                        villa.Image.CopyTo(fileStream);

                    };


                    villa.ImageUrl = @"\images\Villa\"+fileName;

                }
                else
                {
                    villa.ImageUrl = "https://placehold.co/600x400";
                }

                _db.VillaRepository.Add(villa);
                _db.SaveChanges();
                TempData["success"] = "Villa Created Successfully";
                return RedirectToAction(nameof(Index));
            }

            return View(villa);
        }

        public IActionResult Update(int villaId)
        {
            var villa = _db.VillaRepository
                 .Get(a => a.Id == villaId);
            if (villa == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(villa);
        }

        [HttpPost]
        public IActionResult Update(Villa villa)
        {
            if (ModelState.IsValid)
            {



                if (villa.Image != null)
                {
                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(villa.Image.FileName);
                    string imagePath = Path.Combine(_webHostEnvironment.WebRootPath, @"images\Villa");

                    if(!string.IsNullOrEmpty(villa.ImageUrl))
                    {
                        var oldIMage = Path.Combine(_webHostEnvironment.WebRootPath, villa.ImageUrl.TrimStart('\\'));

                        if (System.IO.File.Exists(oldIMage))
                        {
                            System.IO.File.Delete(oldIMage);
                        }
                    }
                    
                    
                    
                    using (var fileStream = new FileStream(Path.Combine(imagePath, fileName), FileMode.Create))
                    {
                        villa.Image.CopyTo(fileStream);
                    } ;


                    villa.ImageUrl = @"\images\Villa\" + fileName;

                }
                else
                {
                    villa.ImageUrl = "https://placehold.co/600x400";
                }










                _db.VillaRepository.Update(villa);
                _db.SaveChanges();
                TempData["success"] = "Villa Update Successfully";

                return RedirectToAction(nameof(Index));
            }

            return View(villa);
        }

        public IActionResult Delete(int villaId)
        {
            var villa = _db.VillaRepository
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


            var villaobj = _db.VillaRepository
                 .Get(a => a.Id == villa.Id);
           
            
            
            if (!string.IsNullOrEmpty(villaobj.ImageUrl))
            {
                var oldIMage = Path.Combine(_webHostEnvironment.WebRootPath, villaobj.ImageUrl.TrimStart('\\'));

                if (System.IO.File.Exists(oldIMage))
                {
                    System.IO.File.Delete(oldIMage);
                }
            }
            if (villaobj is not null)
            {
                _db.VillaRepository.Remove(villaobj);
                _db.SaveChanges();
                TempData["success"] = "Villa Deleted Successfully";

                return RedirectToAction(nameof(Index));
            }

            return View(villa);
        }
    }
}
