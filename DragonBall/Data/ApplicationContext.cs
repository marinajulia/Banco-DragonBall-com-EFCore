using Microsoft.EntityFrameworkCore;
using DragonBall.Models;

namespace DragonBall.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Raca> Raca { get; set; }
        public DbSet<InfoRaca> InfoRaca { get; set; }
        public DbSet<Classe> Classe { get; set; }
        public DbSet<Personagem> Personagem { get; set; }


    }
}
