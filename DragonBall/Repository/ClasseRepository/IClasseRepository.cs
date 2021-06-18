using System.Collections.Generic;
using DragonBall.Models;

namespace DragonBall.Repository.ClasseRepository
{
    public interface IClasseRepository
    {
        IEnumerable<Classe> Get();
        Classe GetById(int id);
        Classe Post(Classe classe);

        // Classe GetByName(string name);
    }

}
