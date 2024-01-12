using SW.Models;
using System;
using System.Linq;

namespace SW.DataAccessLayer
{
    public class EvenementAleatoireRepository
    {
        private readonly StarWarsDBContext _starWarsDBContext;
        private readonly Random _random = new Random();

        public EvenementAleatoireRepository(StarWarsDBContext starWarsDBContext)
        {
            _starWarsDBContext = starWarsDBContext;
        }

        // Méthode pour déclencher un événement aléatoire sur un citoyen spécifique
        public TypeEvenementAleatoire TriggerRandomEvenementAleatoire(Citoyen citoyen)
        {
            var selectedType = GetRandomEvenementType();
            ApplyEvenementImpact(selectedType, citoyen);

            _starWarsDBContext.SaveChanges();

            return selectedType;

        }

        // Sélectionne aléatoirement un type d'événement
        private TypeEvenementAleatoire GetRandomEvenementType()
        {
            var evenementTypes = Enum.GetValues(typeof(TypeEvenementAleatoire))
                                     .Cast<TypeEvenementAleatoire>()
                                     .ToList();

            return evenementTypes[_random.Next(evenementTypes.Count)];
        }

        // Applique l'impact de l'événement sur le citoyen
        // EvenementAleatoireService


        private void ApplyEvenementImpact(TypeEvenementAleatoire eventType, Citoyen citoyen)
        {

            switch (eventType)
            {
                case TypeEvenementAleatoire.CatastropheNaturelle:
                    citoyen.Bonheur -= 5;
                    citoyen.PointsDeMerites -= 5;
                    citoyen.Fertilite -= 2;
                    
                    break;
                case TypeEvenementAleatoire.FeteNationale:
                    citoyen.Bonheur += 10;
                    citoyen.PointsDeMerites += 5;
                    citoyen.Fertilite += 5;
                    break;
               
               
                case TypeEvenementAleatoire.MortParentBiologique:
                    citoyen.Bonheur -= 15;
                    citoyen.PointsDeMerites -= 5;
                    break;

                case TypeEvenementAleatoire.Guerre:
                    citoyen.Bonheur -= 15;
                    citoyen.PointsDeMerites -= 5;
                    citoyen.Fertilite -= 2;

                    break;







                    // Ajoutez d'autres types d'événements si nécessaire
            }

           

            // Mettez à jour les propriétés du citoyen dans la base de données
            _starWarsDBContext.Update(citoyen);
            _starWarsDBContext.SaveChanges();
        }

    }
}
