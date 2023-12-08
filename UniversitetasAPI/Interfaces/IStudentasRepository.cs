using UniversitetasAPI.Models;

namespace UniversitetasAPI.Interfaces
{
    public interface IStudentasRepository
    {
        public IEnumerable<StudentasClass> GetStudentai();
        public IEnumerable<StudentasClass> GetStudentai(int departamentas_id);
        public int UpdateDepartamentasWithStudentai(int id, int student_id);
        public int GetStudentasWithPaskaitos(int studentas_id);
    }
}
