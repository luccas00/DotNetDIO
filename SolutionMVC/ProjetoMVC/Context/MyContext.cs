using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Entities;

namespace ProjetoMVC.Context
{
    public class MyContext : DbContext
    {

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }

        public DbSet<Investimento> Investimentos { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Banco> Bancos { get; set; }

    }
}
