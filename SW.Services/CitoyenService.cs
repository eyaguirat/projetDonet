// SW.Services\CitoyenService.cs

using SW.DataAccessLayer;
using SW.Models;
using System.Collections.Generic;

namespace SW.Services
{
    public class CitoyenService
    {
        private readonly CitoyenRepository _citoyenRepository;

        public CitoyenService(CitoyenRepository citoyenRepository)
        {
            _citoyenRepository = citoyenRepository;
        }

        public void AddCitoyen(Citoyen citoyen)
        {
            _citoyenRepository.AddCitoyen(citoyen);
        }

        public List<Citoyen> GetCitoyens()
        {
            return _citoyenRepository.GetCitoyens();
        }

        public void GererEvenementsAleatoires()
            {
                Random random = new Random();

                // Exemple d'événement affectant la fertilité
                foreach (Citoyen citoyen in _citoyenRepository.GetCitoyens())
                {
                    if (random.Next(0, 100) < 10) // 10% de chance d'impact
                    {
                    citoyen.Fertilite = Math.Max(0, citoyen.Fertilite.GetValueOrDefault() - 1);
                    // Réduction de la fertilité
                }
            }

                // Exemple d'événement affectant les points de mérite
                foreach (Citoyen citoyen in _citoyenRepository.GetCitoyens())
                {
                    if (random.Next(0, 100) < 5) // 5% de chance d'impact
                    {
                    citoyen.PointsDeMerites = Math.Max(0, citoyen.PointsDeMerites.GetValueOrDefault() - 1);
                    // Réduction des points de mérite
                }
            }

    
         
                // Vous pouvez ajouter d'autres types d'événements en fonction de vos besoins
            }
        }
    // Exemple : Appeler les événements aléatoires chaque jour
    // Cela pourrait être dans un service planifié ou un travailleur de fond


    }




