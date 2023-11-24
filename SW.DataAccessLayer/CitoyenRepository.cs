using SW.Models;

namespace SW.DataAccessLayer
{
    public class CitoyenRepository
    {
        public StarWarsDBContext SWDbContext { get; set; }
        public CitoyenRepository(
            StarWarsDBContext starWarsDBContext // Le StarWarsDBContext est injecté grâce au program.cs
        )
        {
            SWDbContext = starWarsDBContext;
        }

        public void AddCitoyen(Citoyen citoyen)
        {
            // Ajout du citoyen dans le contexte des citoyens
            SWDbContext.Citoyens.Add(citoyen);

            // Sauvegarde des changements en base
            SWDbContext.SaveChanges();
        }

        public List<Citoyen> GetCitoyens()
        {
            return SWDbContext.Citoyens.ToList();
        }
    }
}