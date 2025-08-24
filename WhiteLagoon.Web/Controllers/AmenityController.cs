using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WhiteLagoon.Application.common.interfaces;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Web.ModelVM;

namespace WhiteLagoon.Web.Controllers
{
    public class AmenityController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public AmenityController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var amenties = _unitOfWork.AmenityRepository.GetAll(includeProperties:"Villa");
            return View(amenties);
        }














        [HttpGet]
        public IActionResult Create()
        {
            AmenityVM v = new()
            {
                villaList = _unitOfWork.VillaRepository.GetAll()
                     .Select(u => new SelectListItem
                     {
                         Text = u.Name,
                         Value = u.Id.ToString()
                     }),
                amenity = new()
            };



            return View(v);
        }

        [HttpPost]
        public IActionResult Create(AmenityVM villa)
        {
            Amenity nu = villa.amenity;
            if (ModelState.IsValid)
            {
                _unitOfWork.AmenityRepository.Add(nu);
                _unitOfWork.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            AmenityVM v = new()
            {
                villaList = _unitOfWork.VillaRepository.GetAll()
                .Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                amenity = nu
            };
            return View(v);
        }



        public IActionResult Update(int villaId)
        {
            var villa = _unitOfWork.AmenityRepository
                 .Get(a => a.Id == villaId);
            if (villa == null)
            {
                return RedirectToAction("Error", "Home");
            }
            AmenityVM v = new()
            {
                villaList =_unitOfWork.VillaRepository.GetAll()
                .Select(u => new SelectListItem
                {
                    Text = u.Name,
                    Value = u.Id.ToString()
                }),
                amenity = villa
            };
            return View(v);
        }

        [HttpPost]
        public IActionResult Update(AmenityVM villa)
        {
            
            
            if (villa?.amenity?.Id == 0)
            {
                ModelState.AddModelError("", "Amenity Id is missing.");
            }

            if (ModelState.IsValid)
            {
                _unitOfWork.AmenityRepository.Update(villa.amenity);
                _unitOfWork.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                AmenityVM v = new()
                {
                    villaList = _unitOfWork.VillaRepository.GetAll()
                   .Select(u => new SelectListItem
                   {
                       Text = u.Name,
                       Value = u.Id.ToString()
                   }),
                    amenity = villa.amenity
                };
                return View(v);
            }

        }

        public IActionResult Delete(int villaId)
        {
            var villa = _unitOfWork.AmenityRepository
                .Get(a => a.Id == villaId,includeProperties:"Villa");
            ; ;
            if (villa == null)
            {
                return RedirectToAction("Error", "Home");
            }
            return View(villa);
        }

        [HttpPost]
        public IActionResult Delete(Amenity villa)
        {


            
                var villas = _unitOfWork.AmenityRepository
                    .Get(a => a.Id == villa.Id    , includeProperties: "Villa");

                if (villas is not null)
            {
                _unitOfWork.AmenityRepository.Remove(villas);
                _unitOfWork.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(villa);
        }
    }
}
