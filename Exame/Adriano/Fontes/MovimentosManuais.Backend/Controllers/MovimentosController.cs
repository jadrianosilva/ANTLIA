using Microsoft.AspNetCore.Mvc;
using MovimentosManuais.Backend.Models;
using MovimentosManuais.Backend.Services;

namespace MovimentosManuais.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovimentosController : ControllerBase
    {
        private readonly IMovimentoService _service;

        public MovimentosController(IMovimentoService service)
        {
            _service = service;
        }

        [HttpGet("{ano}/{mes}")]
        public async Task<IActionResult> Get(int ano, int mes)
        {
            var movimentos = await _service.ConsultarMovimentos(ano, mes);
            return Ok(movimentos);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] MovimentoManual movimento)
        {
            var novo = await _service.InserirMovimento(movimento);
            return Ok(novo);
        }
    }
}