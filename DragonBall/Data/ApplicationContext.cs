using Microsoft.EntityFrameworkCore;
using DragonBall.Models;
using Microsoft.Extensions.Options;

namespace DragonBall.Data
{
    public class DataContext : DbContext
    {

        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-8024PRG\SERVIDOR;Initial Catalog=DragonBallAPI2;Integrated Security=True");
        }
        public DbSet<Raca> Raca { get; set; }
        public DbSet<InfoRaca> InfoRaca { get; set; }
        public DbSet<Classe> Classe { get; set; }
        public DbSet<Personagem> Personagem { get; set; }


    }
}
