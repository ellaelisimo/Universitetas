using UniversitetasAPI.Interfaces;
using UniversitetasAPI.Models;

namespace UniversitetasAPI.Services
{
    public class PaskaitaService : IPaskaitaService
    {
        private readonly IPaskaitaRepository _paskaitaRepository;
        public PaskaitaService(IPaskaitaRepository paskaitaRepository)
        {
            _paskaitaRepository = paskaitaRepository;
        }
        public List<PaskaitaClass> GetPaskaitos()
        {
            return _paskaitaRepository.GetPaskaitos().ToList();
        }
        public List<PaskaitaClass> GetPaskaitos(int departamentas_id)
        {
            return _paskaitaRepository.GetPaskaitos(departamentas_id).ToList();
        }
    }
}
 