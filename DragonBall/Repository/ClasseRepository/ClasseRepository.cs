using System.Collections.Generic;
using DragonBall.Data;
using DragonBall.Models;
using static DragonBall.Data.DataContext;

namespace DragonBall.Repository.ClasseRepository
{
    public class ClasseRepository : IClasseRepository
    {
        private readonly ApplicationDbContext _context;
        public IEnumerable<Classe> Get()
        {
            using (var context = new DataContext())
            {
            }
        }
    }
}
