using System;
using System.Collections.Generic;
using DragonBall.Data;
using DragonBall.Models;

namespace DragonBall.Repository.PersonagemRepository
{
    public class PersonagemRepository : IPersonagemRepository
    {
        public IEnumerable<Personagem> Get()
        {
            throw new System.NotImplementedException();
        }

        public Personagem GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Personagem Post(Personagem personagem)
        {
            using (var context = new DataContext())
            {
                var jaExiste = VerificarPersonagem.VerificaNomePersonagem(context, personagem.Nome);
                if (!jaExiste)
                {
                    context.Personagem.Add(personagem);
                    context.SaveChanges();
                    return personagem;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
    }
}
