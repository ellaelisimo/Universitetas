using UniversitetasAPI.Models;

namespace UniversitetasAPI.Interfaces
{
    public interface IPaskaitaService
    {
        public List<PaskaitaClass> GetPaskaitos();
        public List<PaskaitaClass> GetPaskaitos(int departamentas_id);
        //public int CreatePaskaita(int paskaita_id, string paskaita_name, int departamentas_id);
        //public int GetPaskaitaPagalStudentas(int paskaita_id);
    }
}
