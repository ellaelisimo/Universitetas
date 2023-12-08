using UniversitetasAPI.Models;

namespace UniversitetasAPI.Interfaces
{
    public interface IDepartamentasService
    {
        public List<DepartamentasClass> GetDepartamentai();
        public int CreateDepartamentas(int id, string name);
    }
}
