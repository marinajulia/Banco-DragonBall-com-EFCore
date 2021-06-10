using System.Collections.Generic;
using DragonBall.Data;
using DragonBall.Models;

namespace DragonBall.Repository.ClasseRepository
{
    public interface IClasseRepository
    {
        IEnumerable<Classe> Get(DataContext context);

    }
}

