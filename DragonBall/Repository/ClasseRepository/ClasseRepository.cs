using System.Collections.Generic;
using DragonBall.Data;
using DragonBall.Models;

namespace DragonBall.Repository.ClasseRepository
{
    public class ClasseRepository : IClasseRepository
    {
        public IEnumerable<Classe> Get()
        {
            using (var context = new DataContext())
            {
            }
        }
    }
}
