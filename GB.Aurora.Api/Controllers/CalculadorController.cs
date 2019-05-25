using GB.Aurora.Domain.Arguments;
using GB.Aurora.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GB.Aurora.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadorController : ControllerBase
    {
        private readonly IAuroraService _auroraService;

        public CalculadorController(IAuroraService auroraService)
        {
            _auroraService = auroraService;
        }

        [HttpPost]
        [Route("CalcularPontos")]
        public IActionResult CalcularPontos([FromBody]CalcularPontosRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var resultado = _auroraService.Calcular(request.ValoresDados);

            return Ok(resultado);
        }
    }
}