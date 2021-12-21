using Microsoft.EntityFrameworkCore;

namespace ProjetoSite.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
    }
}
