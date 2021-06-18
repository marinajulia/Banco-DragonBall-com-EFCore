using System.Collections.Generic;
using System.Linq;
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
                var classes = context.Classe;

                return classes.ToList();
            }
        }

        public Classe GetById(int id)
        {
            using (var context = new DataContext())
            {
                var classe = context.Classe.FirstOrDefault(x => x.ClasseId == id);

                /*
                    context.Add() = insert
                    context.Remove = delete
                    context.Update();
                */
                return classe;
            }
        }

        public Classe Post(Classe classe)
        {
            using (var context = new DataContext())
            {
                context.Classe.Add(classe);
                context.SaveChanges();

                return classe;
            }
        }

        // public Classe GetByName(string name)
        // {
        //     using (var context = new DataContext())
        //     {
        //         var classe = context.Classe.FirstOrDefault(x => x.DescricaoClasse.Trim().ToLower() == name.Trim().ToLower());

        //         return classe;
        //     }
        // }
    }
}
