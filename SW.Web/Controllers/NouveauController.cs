using Microsoft.AspNetCore.Mvc;
using SW.DataAccessLayer;
using SW.Models;
using SW.Services;
using SW.Web.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SW.Web.Controllers
{
    public class NouveauController : Controller
    {
        public DivisionNouveau DivisionNouveau { get; set; }

        public DivisionCitoyen DivisionCitoyen { get; set; }

        public NouveauController(DivisionCitoyen divisionCitoyen)
        {
            DivisionNouveau = new DivisionNouveau();

            DivisionCitoyen = divisionCitoyen;
        }

        public IActionResult Index()
        {
            this.ViewData["Nom"] = "Alexandre";

            // Index doit retourner à la vue une liste de "Nouveau"

            var noms = new List<string>
            {
                "Anakin",
                "Padme",
                "Luke"
            };

            var citoyens = DivisionCitoyen.GetCitoyens();

            return View(noms);
        }

        [HttpGet] // L'action n'est accessible que lors d'une requête en GET
        public IActionResult Add()
        {
            // Instanciation du viewmodel
            var addCitoyenVM = new AddCitoyenViewModel();

            // On configure les espèces disponibles dans le <select>
            addCitoyenVM.Especes = new List<SelectListItem>
            {
                new SelectListItem {Value = "1", Text = "Humains"}
            };

            // On donne le viewmodel à la vue pour qu'elle puisse l'exploiter.
            return View(addCitoyenVM);
        }

        [HttpPost] // L'action n'est accessible que lors d'une requête en POST
        public IActionResult Add(AddCitoyenViewModel newCitoyen)
        {
            DivisionCitoyen.AddCitoyen(new Citoyen
            {
                Nom = newCitoyen.Nom,
                Prenom = newCitoyen.Prenom,
                Age = newCitoyen.Age,
                Espece = new Espece
                {
                    Id = newCitoyen.EspeceId
                }
            });


            return Index();
        }

    }
}
