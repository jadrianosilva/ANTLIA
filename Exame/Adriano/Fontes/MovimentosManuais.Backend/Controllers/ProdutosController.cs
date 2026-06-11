using Microsoft.AspNetCore.Mvc;
using MovimentosManuais.Backend.Services;

namespace MovimentosManuais.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoService _service;

        public ProdutosController(IProdutoService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var produtos = await _service.ConsultarProdutos();
            return Ok(produtos);
        }
    }
}
