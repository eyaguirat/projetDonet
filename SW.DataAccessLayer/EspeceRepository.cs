using SW.Models;
using System.Collections.Generic;
using System.Linq;

namespace SW.DataAccessLayer
{
    public class EspeceRepository
    {
        private readonly StarWarsDBContext _starWarsDBContext;

        public EspeceRepository(StarWarsDBContext starWarsDBContext)
        {
            _starWarsDBContext = starWarsDBContext;
        }

        public void AddEspece(Espece espece)
        {
            _starWarsDBContext.Especes.Add(espece);
            _starWarsDBContext.SaveChanges();
        }

        public List<Espece> GetAllEspeces()
        {
            return _starWarsDBContext.Especes.ToList();
        }

        public Espece GetEspeceById(int id)
        {
            return _starWarsDBContext.Especes.FirstOrDefault(e => e.Id == id);
        }

        public void UpdateEspece(Espece espece)
        {
            var existingEspece = _starWarsDBContext.Especes.FirstOrDefault(e => e.Id == espece.Id);
            if (existingEspece != null)
            {
                existingEspece.Nom = espece.Nom;
                existingEspece.Longevite = espece.Longevite;
                existingEspece.Majorite = espece.Majorite;
                _starWarsDBContext.SaveChanges();
            }
        }

        public void DeleteEspece(int id)
        {
            var espece = _starWarsDBContext.Especes.FirstOrDefault(e => e.Id == id);
            if (espece != null)
            {
                _starWarsDBContext.Especes.Remove(espece);
                _starWarsDBContext.SaveChanges();
            }
        }
    }
}