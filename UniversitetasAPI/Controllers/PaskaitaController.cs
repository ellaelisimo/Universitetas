using Microsoft.AspNetCore.Mvc;
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

    }
}
