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

    }
}
