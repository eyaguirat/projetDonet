using SW.Models;
using SW.Services;

namespace SW.Tests
{
    public class DivisionTests
    {
        [Fact]
        public void TestAddDistinctionFonctionnaireANouveau()
        {
            var e = new Espece
            {
                Nom = "Humain",
                Longevite = 80,
                Majorite = 16
            };
            var fonctionnaire = new Fonctionnaire
            {
                Id = 1,
                Nom = "Skywalker",
                Prenom = "Anakin",
                Age = 18,
                Espece = e
            };
            var nouveau = new Nouveau
            {
                Id = 2,
                Nom = "Skywalker",
                Prenom = "Luke",
                Age = 18,
                Espece = e
            };

            var divisionNouveau = new DivisionNouveau();
            var distinction = new Distinction
            {
                BonusMerite = 10,
                Date = DateTime.Now,
                DecernePar = fonctionnaire,
                DecerneA = nouveau
            };
            divisionNouveau.AddDistinction(distinction);
        }

        [Fact]
        public void TestAddSanctionFonctionnaireANouveau() { 

        }

        [Fact]
        public void TestAddDistinctionPatrioteAPatriote() { 

        }

        [Fact]
        public void TestAddSanctionFonctionnaireAPatriote() { 

        }

        [Fact]
        public void TestAddDistinctionParPereOuMere() { 

        }

        [Fact]
        public void TestAddDistinctionParAscendant() { 

        }

        [Fact]
        public void TestAddSanctionParCitoyenMemeCaste() { 

        }

        [Fact]
        public void TestAddDistinctionParCitoyenCasteInferieure() { 

        }

        [Fact]
        public void TestAddDistinctionSousSanctionMoinsDe6Mois() { 

        }
    }
}