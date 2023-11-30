using Microsoft.EntityFrameworkCore;
using WebApplication2.ModelsDisco;
using WebApplication2.ModelsMusica;

namespace WebApplication2.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<Disco> Disco { get; set; }
        public DbSet<Musica> Musica { get; set; }
    }
}
