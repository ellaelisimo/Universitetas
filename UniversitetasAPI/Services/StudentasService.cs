using UniversitetasAPI.Interfaces;
using UniversitetasAPI.Models;

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
    }
}
