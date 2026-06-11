using Microsoft.EntityFrameworkCore;
using MovimentosManuais.Backend.Models;

namespace MovimentosManuais.Backend.Services
{
    public class MovimentoService : IMovimentoService
    {
        private readonly MovimentosContext _context;

        public MovimentoService(MovimentosContext context)
        {
            _context = context;
        }

        public async Task<int> GerarNumeroLancamento(int ano, int mes)
        {
            var ultimo = await _context.Movimentos
                .Where(m => m.DatAno == ano && m.DatMes == mes)
                .OrderByDescending(m => m.NumLancamento)
                .FirstOrDefaultAsync();

            return ultimo == null ? 1 : ultimo.NumLancamento + 1;
        }

        public async Task<MovimentoManual> InserirMovimento(MovimentoManual movimento)
        {
            movimento.NumLancamento = await GerarNumeroLancamento(movimento.DatAno, movimento.DatMes);
            movimento.DatMovimento = DateTime.Now;
            _context.Movimentos.Add(movimento);
            await _context.SaveChangesAsync();
            return movimento;
        }

        public async Task<List<MovimentoManual>> ConsultarMovimentos(int ano, int mes)
        {
            return await _context.Movimentos
                .Where(m => m.DatAno == ano && m.DatMes == mes)
                .ToListAsync();
        }
    }
}