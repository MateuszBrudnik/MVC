using Microsoft.AspNetCore.Mvc;
using MVC_LAB.Models;
using MVC_LAB.Models.Person;
using System.Diagnostics;

namespace MVC_LAB.Controllers
{
    public class PersonController : Controller
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new PersonViewModel()
            {
                Persons = new PersonModel().GetPersons()
            };
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
