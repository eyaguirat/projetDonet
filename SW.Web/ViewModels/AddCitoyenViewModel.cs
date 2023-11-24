using Microsoft.AspNetCore.Mvc.Rendering;
using SW.Models;

namespace SW.Web.ViewModels
{
    /// <summary>
    /// ViewModel utilisé uniquement pour ajouter un nouveau citoyen
    /// Le ViewModel est utilisé dans la view Nouveau/Add.cshtml
    /// </summary>
    public class AddCitoyenViewModel
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public int EspeceId { get; set; }

        /// <summary>
        /// Liste de SelectListItem permettant d'afficher les espèces de l'empire.
        /// </summary>
        public List<SelectListItem> Especes { get; set; }
    }
}
