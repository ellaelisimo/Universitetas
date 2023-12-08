using UniversitetasAPI.Interfaces;
using UniversitetasAPI.Repositories;
using UniversitetasAPI.Models;

namespace UniversitetasAPI.Services
{
    public class DepartamentasService : IDepartamentasService
    {
        private readonly IDepartamentasRepository _departamentasRepository;
        public DepartamentasService (IDepartamentasRepository departamentasRepository)
        {
            _departamentasRepository = departamentasRepository;
        }
        public List<DepartamentasClass> GetDepartamentai()
        {
            return _departamentasRepository.GetDepartamentai().ToList();
        }
        public int CreateDepartamentas(int id, string name)
        {
            return _departamentasRepository.CreateDepartamentas (id, name);
        }
    }
}
