using Microsoft.AspNetCore.Mvc;
using UniversitetasAPI.Interfaces;

namespace UniversitetasAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentasController : Controller
    {
        private readonly IStudentasService _studentasService;
        public StudentasController(IStudentasService studentasService)
        {
            _studentasService = studentasService;
        }
        [HttpGet]
        public async Task<IActionResult> GetStudentai()
        {
            return Ok(_studentasService.GetStudentai());
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDepartamentasWithStudentai(int id, int studentas_id)
        {
            return Ok(_studentasService.UpdateDepartamentasWithStudentai(id, studentas_id));
        }
        [HttpGet]
        public async Task<IActionResult> GetStudentasWithPaskaitos(int studentas_id)
        {
            return Ok(_studentasService.GetStudentasWithPaskaitos(studentas_id));
        }

    }
}
