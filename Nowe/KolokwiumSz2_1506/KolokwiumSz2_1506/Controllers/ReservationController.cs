using KolokwiumSz2_1506.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SzkolenieKolokwium.storage.Services;

namespace KolokwiumSz2_1506.Controllers
{
    public class ReservationController : Controller
    {
        public readonly IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }
        public IActionResult Index()
        {
            var result = _reservationService.Read();
            return View(result);
        }

        public IActionResult Add()
        {
            var model = new ReservationAddModel();
            model.Rooms = _reservationService.ReadRooms().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name
            }).ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(ReservationAddModel model)
        {
            if (ModelState.IsValid)
            {
                _reservationService.Create(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
