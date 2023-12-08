using UniversitetasAPI.Models;

namespace UniversitetasAPI.Interfaces
{
    public interface IDepartamentasRepository
    {
        public IEnumerable<DepartamentasClass> GetDepartamentai();
        public int CreateDepartamentas(int id, string name);
    }
}
