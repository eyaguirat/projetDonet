using Microsoft.AspNetCore.Mvc;
using SW.Models;
using SW.Services;
using SW.Web.ViewModels; // Assurez-vous d'ajouter ce namespace s'il n'est pas déjà présent

namespace SW.Web.Controllers
{
    public class CitoyenController : Controller
    {
        private readonly CitoyenService _citoyenService;

        public CitoyenController(CitoyenService citoyenService)
        {
            _citoyenService = citoyenService;
        }

        // GET: Citoyen
        public IActionResult Index()
        {
            var citoyens = _citoyenService.GetCitoyens();
            return View(citoyens);
        }

        // GET: Citoyen/Add
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        // POST: citoyen/Add
        [HttpPost]
        public IActionResult Add(Citoyen citoyen)

        {
            if (ModelState.IsValid)
            {
                _citoyenService.AddCitoyen(citoyen);
               
                return RedirectToAction(nameof(Index));
            }
            return View(citoyen);
        }
    }
}
