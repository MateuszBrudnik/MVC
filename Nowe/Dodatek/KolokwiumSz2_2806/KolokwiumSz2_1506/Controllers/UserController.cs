using KolokwiumSz2_1506.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using SzkolenieKolokwium.storage.Services;

namespace Aplikacja.Controllers
{
    public class UserController : Controller
    {
        private readonly IKonkursy _konkursy;

        public UserController(IKonkursy konkursy)
        {
            _konkursy = konkursy;
        }

        public IActionResult Index()
        {
            var result = _konkursy.GetAll();
            return View(result);
        }

        public IActionResult Add()
        {
            var model = new UserAddModel();
            model.Konkursy = _konkursy.ReadKonkursy().Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Nazwa
            }).ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(UserAddModel model)
        {
            if (ModelState.IsValid)
            {
                _konkursy.AddUser(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult AddKonkurs()
        {
            
            return View();
        }

        [HttpPost]
        public IActionResult AddKonkurs(KonkursAddModel model)
        {
            if (ModelState.IsValid)
            {
                _konkursy.AddKonkurs(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
