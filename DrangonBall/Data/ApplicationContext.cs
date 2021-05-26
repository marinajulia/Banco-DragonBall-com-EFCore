using DrangonBall.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrangonBall.Data {
    public class ApplicationContext : DbContext {
        public DbSet<Raca> Racas { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Personagem> Personagens { get; set; }
        public DbSet<InfoRaca> InfoRacas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-8024PRG\SERVIDOR;Initial Catalog=DragonBallEFCore;Integrated Security=True");
        }
    }
}
