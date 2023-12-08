using Microsoft.AspNetCore.Mvc;
using UniversitetasAPI.DTO;
using UniversitetasAPI.Interfaces;

namespace UniversitetasAPI.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PaskaitaController : Controller
    {
        private readonly IPaskaitaService _paskaitaService;
        public PaskaitaController(IPaskaitaService paskaitaService)
        {
            _paskaitaService = paskaitaService;
        }
        [HttpGet]
        public async Task<IActionResult> GetPaskaitos()
        {
            return Ok(_paskaitaService.GetPaskaitos());
        }
        [HttpPut]
        public async Task<IActionResult> CreatePaskaita([FromBody] CreatePaskaitosDTO paskaita)
        {
            return Ok(_paskaitaService.CreatePaskaita(paskaita.Id, paskaita.departamentasId, paskaita.Name));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateDepartamentasWithPaskaitos(int id, int paskaita_id)
        {
            if (_paskaitaService.UpdateDepartamentasWithPaskaitos(id, paskaita_id) == 1)
            {
                return Ok(_paskaitaService.GetPaskaitos());
            }
            else
                return BadRequest("Įveskite teisingą sintaksę");
        }
    }
}
