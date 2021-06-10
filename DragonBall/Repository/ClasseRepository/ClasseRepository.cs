using System.Collections.Generic;
using DragonBall.Data;
using DragonBall.Models;

namespace DragonBall.Repository.ClasseRepository
{
    public class ClasseRepository : IClasseRepository
    {

        // public IEnumerable<Classe> Get()
        // {
        //     using(var context = new DataContext()){
        //     }
        // }

        public IEnumerable<Classe> Get(DataContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}
