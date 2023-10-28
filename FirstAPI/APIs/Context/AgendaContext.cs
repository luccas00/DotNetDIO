using Biblioteca;
using Microsoft.EntityFrameworkCore;

namespace APIs.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) { }

        public DbSet<Contatos> Contatos { get; set; }

    }
}
