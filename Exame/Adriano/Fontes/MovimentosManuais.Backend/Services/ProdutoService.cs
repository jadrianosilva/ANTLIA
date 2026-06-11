using Microsoft.EntityFrameworkCore;
using MovimentosManuais.Backend.Models;

namespace MovimentosManuais.Backend.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly MovimentosContext _context;

        public ProdutoService(MovimentosContext context)
        {
            _context = context;
        }

        public async Task<List<Produto>> ConsultarProdutos()
        {
            return await _context.Produtos
                .Where(p => p.StaStatus == "A")
                .ToListAsync();
        }

        public async Task<List<ProdutoCosif>> ConsultarCosifs(string codProduto)
        {
            return await _context.ProdutosCosif
                .Where(c => c.CodProduto == codProduto && c.StaStatus == "A")
                .ToListAsync();
        }
    }
}
