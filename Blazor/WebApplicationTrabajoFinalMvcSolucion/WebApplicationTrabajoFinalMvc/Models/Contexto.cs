using Microsoft.EntityFrameworkCore;

namespace WebApplicationTrabajoFinalMvc.Models
{
    public class Contexto : DbContext 
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }    


    }
}
