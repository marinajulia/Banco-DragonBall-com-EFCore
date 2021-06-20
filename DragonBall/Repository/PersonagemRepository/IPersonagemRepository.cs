using System.Collections.Generic;
using DragonBall.Models;

namespace DragonBall.Repository.PersonagemRepository
{
    public interface IPersonagemRepository
    {
        IEnumerable<Personagem> Get();
        Personagem GetById(int id);
        Personagem Post(Personagem personagem);
    }
}
