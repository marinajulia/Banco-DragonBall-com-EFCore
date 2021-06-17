using System.Collections.Generic;
using DragonBall.Models;

namespace DragonBall.Repository.RacaRepository
{
    public interface IRacaRepository
    {
        IEnumerable<Raca> Get();
        Raca GetById(int id);
        int Post(Raca raca);
    }
}
