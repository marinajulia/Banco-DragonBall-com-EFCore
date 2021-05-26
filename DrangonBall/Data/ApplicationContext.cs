using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrangonBall.Data {
    public class ApplicationContext : DbContext {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer((@"Data Source=DESKTOP-8024PRG\SERVIDOR;Initial Catalog=DragonBallEFCore;Integrated Security=True");
        }
    }
}
