using SW.DataAccessLayer;
using SW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SW.Services
{
    public class DivisionCitoyen
    {
        public CitoyenRepository CitoyenRepository { get; set; }

        public DivisionCitoyen(CitoyenRepository repository)
        {
            CitoyenRepository = repository;
        }

        public void AddCitoyen(Citoyen c)
        {
            // Règles de gestion
            // Age des parents, présence des parents, espèce, etc
            CitoyenRepository.AddCitoyen(c);
        }

        public List<Citoyen> GetCitoyens()
        {
            return CitoyenRepository.GetCitoyens();
        }
    }
}
