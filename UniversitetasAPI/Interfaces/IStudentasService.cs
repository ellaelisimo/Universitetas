using UniversitetasAPI.Models;

namespace UniversitetasAPI.Interfaces
{
    public interface IStudentasService
    {
        public List<StudentasClass> GetStudentai();
        public List<StudentasClass> GetStudentai(int departamentas_id);
        //public int CreateStudentas(int studentas_id, string studentas_name, string studentas_lastname, int departamentas_id, int paskaita_id);
        //public int TransferStudentas(int studentas_id, string studentas_name, string studentas_lastname, int departamentas_id, int paskaita_id);

    }
}
