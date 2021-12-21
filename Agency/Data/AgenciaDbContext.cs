using Agency.Models;
using Microsoft.EntityFrameworkCore;

namespace Agency.Data
{
    public class AgenciaDbContext : DbContext
    {
        public AgenciaDbContext(DbContextOptions<AgenciaDbContext> opt) : base(opt)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Destino> Destinos { get; set; }


    }
}