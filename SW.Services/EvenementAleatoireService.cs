using SW.DataAccessLayer;
using SW.Models;
using System;
using System.Linq;

namespace SW.Services
{
    public class EvenementAleatoireService
    {
        private readonly EvenementAleatoireRepository _evenementAleatoireRepository;
        private readonly CitoyenRepository _citoyenRepository;
        private readonly Random _random;

        public EvenementAleatoireService(EvenementAleatoireRepository evenementAleatoireRepository, CitoyenRepository citoyenRepository)
        {
            _evenementAleatoireRepository = evenementAleatoireRepository;
            _citoyenRepository = citoyenRepository;
            _random = new Random();
        }



        // Déclenche un événement aléatoire sur un citoyen choisi aléatoirement
        public void ApplyRandomEvenementToCitoyen()
        {
            // Récupérez la liste des IDs de tous les citoyens
            var allCitoyenIds = _citoyenRepository.GetCitoyens().Select(c => c.Id).ToList();

            if (allCitoyenIds.Any())
            {
                // Sélectionnez un ID aléatoire
                int randomId = allCitoyenIds[_random.Next(allCitoyenIds.Count)];

                // Récupérez le citoyen correspondant à cet ID
               

                // Appliquez l'événement aléatoire au citoyen sélectionné
                
                _evenementAleatoireRepository.TriggerRandomEvenementAleatoire(_citoyenRepository.GetCitoyenById(randomId));
                
            }
        }



    }
}