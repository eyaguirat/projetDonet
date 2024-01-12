using SW.Models;
using System.Collections.Generic;
using System.Linq;
namespace SW.DataAccessLayer
{
    public class CitoyenRepository
    {
        private readonly StarWarsDBContext _starWarsDBContext;
        public CitoyenRepository(
            StarWarsDBContext starWarsDBContext // Le StarWarsDBContext est injecté grâce au program.cs
        )
        {
            _starWarsDBContext = starWarsDBContext;
        }

        public void AddCitoyen(Citoyen citoyen)
        {
            // Ajout du citoyen dans le contexte des citoyens
            _starWarsDBContext.Citoyens.Add(citoyen);

            // Sauvegarde des changements en base
            _starWarsDBContext.SaveChanges();
        }

      
        public List<Citoyen> GetCitoyens()
        {
            return _starWarsDBContext.Citoyens.ToList();
        }

        public Citoyen GetCitoyenById(int id)
        {
            return _starWarsDBContext.Citoyens.FirstOrDefault(c => c.Id == id);
        }
    }
}