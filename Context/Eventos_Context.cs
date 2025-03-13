using Event_plus.Domains;
using Microsoft.EntityFrameworkCore;

namespace Event_plus.Context_
{
    public class Eventos_Context : DbContext
    {
        public Eventos_Context()
        {
        }

        public Eventos_Context(DbContextOptions<Eventos_Context> options) : base(options) 
        {
        }

        public DbSet<ComentariosEventos> ComentariosEventos { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<Instituicoes> Instituicoes { get; set; }
        public DbSet<PresencasEventos> PresencasEventos { get; set; }
        public DbSet<TiposEventos> TiposEventos { get; set; }
        public DbSet<TiposUsuarios> TiposUsuarios { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = NOTE26-S28\\SQLEXPRESS; Database = Event_plus; User Id = sa; Pwd = Senai@134; TrustServerCertificate=true;");
            }
        }
    }

}
