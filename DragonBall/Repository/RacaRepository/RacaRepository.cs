using System.Collections.Generic;
using System.Linq;
using DragonBall.Data;
using DragonBall.Models;

namespace DragonBall.Repository.RacaRepository
{
    public class RacaRepository : IRacaRepository
    {
        public IEnumerable<Raca> Get()
        {
            using (var context = new DataContext())
            {
                var raca = context.Raca;
                return raca;
            }
        }

        public Raca GetById(int id)
        {
            using (var context = new DataContext())
            {
                var raca = context.Raca.FirstOrDefault(x => x.RacaId == id);
                return raca;
            }
        }

        public int Post(Raca raca)
        {
            using (var context = new DataContext())
            {
                context.Raca.Add(raca);
                context.SaveChanges();
                return raca.RacaId;
            }
        }
    }
}
