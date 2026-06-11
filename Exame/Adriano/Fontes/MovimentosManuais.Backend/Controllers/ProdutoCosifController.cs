using Microsoft.AspNetCore.Mvc;
using MovimentosManuais.Backend.Services;

namespace MovimentosManuais.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoCosifController : ControllerBase
    {
        private readonly IProdutoService _service;

        public ProdutoCosifController(IProdutoService service)
        {
            _service = service;
        }

        [HttpGet("{codProduto}")]
        public async Task<IActionResult> Get(string codProduto)
        {
            var cosifs = await _service.ConsultarCosifs(codProduto);
            return Ok(cosifs);
        }
    }
}