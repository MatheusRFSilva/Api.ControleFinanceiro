
using Api.ControleFinanceiro.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.ControleFinanceiro.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :
        base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Conta> Contas { get; set; }

        public DbSet<Lancamento> Lancamentos { get; set; }
        public DbSet<TipoLancamento> TipoLancamentos { get; set; }
    }
}