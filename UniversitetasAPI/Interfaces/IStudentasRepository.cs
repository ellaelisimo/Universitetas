using UniversitetasAPI.Models;

namespace UniversitetasAPI.Interfaces
{
    public interface IStudentasRepository
    {
        public IEnumerable<StudentasClass> GetStudentai();
        public IEnumerable<StudentasClass> GetStudentai(int departamentas_id);
        //public int CreateStudentas(int studentas_id, string studentas_name, string studentas_lastname, int departamentas_id, int paskaita_id);
       // public int TransferStudentas(int studentas_id, string studentas_name, string studentas_lastname, int departamentas_id, int paskaita_id);
    }
}
