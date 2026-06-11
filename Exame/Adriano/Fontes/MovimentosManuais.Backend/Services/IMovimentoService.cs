using MovimentosManuais.Backend.Models;

namespace MovimentosManuais.Backend.Services
{
    public interface IMovimentoService
    {
        Task<int> GerarNumeroLancamento(int ano, int mes);
        Task<MovimentoManual> InserirMovimento(MovimentoManual movimento);
        Task<List<MovimentoManual>> ConsultarMovimentos(int ano, int mes);
    }
}
