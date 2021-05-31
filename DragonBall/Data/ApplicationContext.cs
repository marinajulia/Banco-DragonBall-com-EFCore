using DragonBall.Models;
using Microsoft.EntityFrameworkCore;


namespace DragonBall.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Raca> Raca { get; set; }
        public DbSet<InfoRaca> InfoRaca { get; set; }
        public DbSet<Classe> Classe { get; set; }
        public DbSet<Personagem> Personagem { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-8024PRG\SERVIDOR;Initial Catalog=DragonBall;Integrated Security=True")
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
        }

    }
}
