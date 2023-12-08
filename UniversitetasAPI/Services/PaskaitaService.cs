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
        public int CreatePaskaita(int id, int departamentas_id, string name)
        {
            return _paskaitaRepository.CreatePaskaita(id, departamentas_id, name);
        }
        public int UpdateDepartamentasWithPaskaitos(int id, int paskaita_id)
        {
            return _paskaitaRepository.UpdateDepartamentasWithPaskaitos(id, paskaita_id);
        }
    }
}
 