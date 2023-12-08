using UniversitetasAPI.Interfaces;
using UniversitetasAPI.Models;

namespace UniversitetasAPI.DTO
{
    public class Converter
    {
        private readonly IStudentasService _studentasService;
        private readonly IPaskaitaService _paskaitaService;
        public Converter(IStudentasService studentasService, IPaskaitaService paskaitaService)
        {
            _studentasService = studentasService;
            _paskaitaService = paskaitaService;
        }
        public DepartamentasDTO ToDTO(DepartamentasClass department)
        {
            var studentai = _studentasService.GetStudentai(department.departamentas_id);
            var paskaitos = _paskaitaService.GetPaskaitos(department.departamentas_id);

            return new DTO.DepartamentasDTO
            {
                id = department.departamentas_id,
                name = department.departamentas_name,
                studentai = studentai.Select(ToDTO).ToArray(),
                paskaitos = paskaitos.Select(ToDTO).ToArray(),
            };
        }
        public StudentasDTO ToDTO(StudentasClass studentas)
        {
            return new StudentasDTO
            {
                id = studentas.studentas_id,
                firstName = studentas.studentas_name,
                lastName = studentas.studentas_lastname,
                paskaitaId = studentas.paskaita_id,
                departamentasId = studentas.departamentas_id,
            };
        }
        public PaskaitaDTO ToDTO(PaskaitaClass paskaita)
        {
            return new PaskaitaDTO
            {
                id = paskaita.paskaita_id,
                name = paskaita.paskaita_name,
                departamentasId = paskaita.departamentas_id,

            };
        }
    }
}
