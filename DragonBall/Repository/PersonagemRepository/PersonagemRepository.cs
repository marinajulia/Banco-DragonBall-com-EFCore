using System;
using System.Collections.Generic;
using System.Linq;
using DragonBall.Data;
using DragonBall.Models;

namespace DragonBall.Repository.PersonagemRepository
{
    public class PersonagemRepository : IPersonagemRepository
    {
        public IEnumerable<Personagem> Get()
        {
            using (var context = new DataContext())
            {
                var personagens = context.Personagem;

                return personagens.ToList();
            }
        }

        public Personagem GetById(int id)
        {
            using (var context = new DataContext())
            {
                var personagem = context.Personagem.FirstOrDefault(x => x.PersonagemId == id);
                return personagem;
            }
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
