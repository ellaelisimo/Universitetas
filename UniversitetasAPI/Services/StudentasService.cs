using UniversitetasAPI.Interfaces;
using UniversitetasAPI.Models;
using UniversitetasAPI.Repositories;

namespace UniversitetasAPI.Services
{
    public class StudentasService : IStudentasService
    {
        private readonly IStudentasRepository _studentasRepository;
        public StudentasService(IStudentasRepository studentasRepository)
        {
            _studentasRepository = studentasRepository;
        }
        public List<StudentasClass> GetStudentai()
        {
            return _studentasRepository.GetStudentai().ToList();
        }

        public List<StudentasClass> GetStudentai(int departamentas_id)
        {
            return _studentasRepository.GetStudentai(departamentas_id).ToList();

        }

        public int UpdateDepartamentasWithStudentai(int id, int studentas_id)
        {
            return _studentasRepository.UpdateDepartamentasWithStudentai(id, studentas_id);
        }
        public int GetStudentasWithPaskaitos(int studentas_id)
        {
            return _studentasRepository.GetStudentasWithPaskaitos(studentas_id);
        }
    }
}
