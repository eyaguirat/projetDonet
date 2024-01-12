using Microsoft.AspNetCore.Mvc;
using SW.Models;
using SW.Services;
using SW.Web.ViewModels; // Assurez-vous d'ajouter ce namespace s'il n'est pas déjà présent

namespace SW.Web.Controllers
{
    public class CitoyenController : Controller
    {
        private readonly CitoyenService _citoyenService;
        private readonly EvenementAleatoireService _evenementAleatoireService;

        public CitoyenController(CitoyenService citoyenService, EvenementAleatoireService evenementAleatoireService)
        {
            _citoyenService = citoyenService;
            _evenementAleatoireService = evenementAleatoireService;
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
            var citoyens = _citoyenService.GetCitoyens();

            var viewModel = new Citoyen
            {
                Citoyens = citoyens.ToList()
            };

            return View(viewModel);
        }
        // POST: citoyen/Add
        [HttpPost]
        public IActionResult Add(Citoyen citoyen)
        {
            citoyen.Citoyens = _citoyenService.GetCitoyens().ToList();


            citoyen.PereBiologique = citoyen.Citoyens.FirstOrDefault(c => c.Id == citoyen.PereBiologiqueID);

            citoyen.MereBiologique = citoyen.Citoyens.FirstOrDefault(c => c.Id == citoyen.MereBiologiqueID);

            _citoyenService.AddCitoyen(citoyen);
            return RedirectToAction(nameof(Index));

        }

        [HttpPost]
        public IActionResult ApplyRandomEvenement()   
        {
            _evenementAleatoireService.ApplyRandomEvenementToCitoyen();

            var citoyens = _citoyenService.GetCitoyens();


            return View("Index", citoyens);
        }

    }
}
