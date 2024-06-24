using Microsoft.EntityFrameworkCore;

namespace WebApplicationTrabajoFinalMvc.Models
{
    public class Contexto : DbContext 
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Divisa> Divisas { get; set; }
        public DbSet<Historico> Historicos { get; set; }
        public DbSet<Pais> Pais { get; set; }
    }
}
