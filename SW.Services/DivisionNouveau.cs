using SW.Models;

namespace SW.Services
{
    public class DivisionNouveau
    {
        public List<Nouveau> Nouveaux { get; set; }

        public DivisionNouveau()
        {
            Nouveaux = new List<Nouveau>();
        }

        public void AddNouveau(Nouveau nouveau)
        {

        }

        public Nouveau GetNouveau(int id)
        {
            return Nouveaux.First(x => x.Id == id);
        }

        public void RemoveNouveau(int id)
        {
            var index = Nouveaux.FindIndex(x => x.Id == id);
            Nouveaux.RemoveAt(index);
        }

        public void AddDistinction(Distinction distinction)
        {
            if (distinction.DecernePar is Nouveau)
            {
                return;
            }


        }

        public void AddSanction(Sanction sanction)
        {

        }
    }


}