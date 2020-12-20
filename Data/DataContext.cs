
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
    }
}