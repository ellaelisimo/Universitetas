using Microsoft.AspNetCore.Mvc;
using UniversitetasAPI.DTO;
using UniversitetasAPI.Interfaces;
using UniversitetasAPI.Models;
using UniversitetasAPI.Services;

namespace UniversitetasAPI.Controllers
{
        [ApiController]
        [Route("[controller]/[action]")]
    public class DepartamentasController : Controller
    {
        private readonly IDepartamentasService _departamentasService;
        private readonly Converter _converter;

        public DepartamentasController (IDepartamentasService departamentasService, IStudentasService studentasService, IPaskaitaService paskaitaService)
        {
            _departamentasService = departamentasService;
            _converter = new Converter(studentasService, paskaitaService);
        }
        [HttpGet]
        public async Task<IActionResult> GetDepartamentai()
        {
            var departamentai = _departamentasService.GetDepartamentai();
            var result = new List<DTO.DepartamentasDTO>();
            foreach(var department in departamentai)
            {
                result.Add(_converter.ToDTO(department));
            }
            return base.Ok(result);

        }
        [HttpPost]
        public async Task<IActionResult> CreateDepartamentas([FromBody] CreateDepartamentasDTO departamentas)
        {

            if (_departamentasService.CreateDepartamentas(departamentas.Id, departamentas.Name) == 1)
            {
                return Ok(_departamentasService.GetDepartamentai());
            }
            else
                return BadRequest("Įveskite teisingą sintaksę");
        }
        
    }
}
