using UniversitetasAPI.Models;

namespace UniversitetasAPI.Interfaces
{
    public interface IStudentasService
    {
        public List<StudentasClass> GetStudentai();
        public List<StudentasClass> GetStudentai(int departamentas_id);
        public int UpdateDepartamentasWithStudentai(int id, int student_id);
        public int GetStudentasWithPaskaitos(int studentas_id);
    }
}
