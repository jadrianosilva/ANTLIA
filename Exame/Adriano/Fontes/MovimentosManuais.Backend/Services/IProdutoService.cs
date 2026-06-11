using MovimentosManuais.Backend.Models;

namespace MovimentosManuais.Backend.Services
{
    public interface IProdutoService
    {
        Task<List<Produto>> ConsultarProdutos();
        Task<List<ProdutoCosif>> ConsultarCosifs(string codProduto);
    }
}
