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

        public Personagem GetByName(string nome)
        {
            using (var context = new DataContext())
            {
                var personagem = context.Personagem.FirstOrDefault(x => x.Nome.Trim().ToLower() == nome.Trim().ToLower());
                return personagem;
            }
        }

        public Personagem Post(Personagem personagem)
        {
            using (var context = new DataContext())
            {
                context.Personagem.Add(personagem);
                context.SaveChanges();
                return personagem;
            }
        }
    }
}
