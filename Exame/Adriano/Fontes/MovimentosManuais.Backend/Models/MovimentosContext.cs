using Microsoft.EntityFrameworkCore;

namespace MovimentosManuais.Backend.Models
{
    public class MovimentosContext : DbContext
    {
        public MovimentosContext(DbContextOptions<MovimentosContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoCosif> ProdutosCosif { get; set; }
        public DbSet<MovimentoManual> Movimentos { get; set; }
    }
}
