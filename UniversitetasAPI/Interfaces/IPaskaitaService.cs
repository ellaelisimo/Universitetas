using UniversitetasAPI.Models;

namespace UniversitetasAPI.Interfaces
{
    public interface IPaskaitaService
    {
        public List<PaskaitaClass> GetPaskaitos();
        public List<PaskaitaClass> GetPaskaitos(int departamentas_id);
        public int CreatePaskaita(int id, int departamentas_id, string name);
        public int UpdateDepartamentasWithPaskaitos(int id, int paskaita_id);
    }
}
