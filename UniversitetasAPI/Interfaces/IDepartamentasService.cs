using UniversitetasAPI.Models;

namespace UniversitetasAPI.Interfaces
{
    public interface IDepartamentasService
    {
        public List<DepartamentasClass> GetDepartamentai();
        public int CreateDepartamentas(int id, string name);
        public int UpdateDepartamentas(int id, string name);
        //public int CreateDepartamentas(int departamentas_id, string departamentas_name, int studentas_id, int paskaita_id);
        //public int UpdateDepartamentas(int departamentas_id, string departamentas_name, int studentas_id, int paskaita_id);
    }
}
