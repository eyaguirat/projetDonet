using SW.DataAccessLayer;
using SW.Models;


namespace SW.Services
{
    public class EspeceService
    {
        private readonly EspeceRepository _especeRepository;

        public EspeceService(EspeceRepository especeRepository)
        {
            _especeRepository = especeRepository;
        }

        public void AddEspece(Espece espece)
        {
            _especeRepository.AddEspece(espece);
        }

        public List<Espece> GetAllEspeces()
        {
            return _especeRepository.GetAllEspeces();
        }

        public Espece GetEspeceById(int id)
        {
            return _especeRepository.GetEspeceById(id);
        }

        public void UpdateEspece(Espece espece)
        {
            _especeRepository.UpdateEspece(espece);
        }

        public void DeleteEspece(int id)
        {
            _especeRepository.DeleteEspece(id);
        }
    }
}