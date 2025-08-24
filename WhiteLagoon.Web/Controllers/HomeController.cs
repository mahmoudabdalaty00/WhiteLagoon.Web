using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WhiteLagoon.Application.common.interfaces;
using WhiteLagoon.Web.Models;
using WhiteLagoon.Web.ModelVM;

namespace WhiteLagoon.Web.Controllers
{
    public class HomeController : Controller
    {
         private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            HomeVM vm = new()
            {
                VillaList = _unitOfWork.VillaRepository.GetAll(includeProperties: "Amenities"),
                Nights = 1,
                CheckInDate = DateOnly.FromDateTime(DateTime.Now),      
            };
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
