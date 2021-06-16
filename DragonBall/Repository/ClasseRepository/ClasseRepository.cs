using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DragonBall.Data;
using DragonBall.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DragonBall.Repository.ClasseRepository
{
    public class ClasseRepository : IClasseRepository
    {
        public IEnumerable<Classe> Get()
        {
            using (var context = new DataContext())
            {
                var classes = context.Classe;

                return classes;
            }
        }

        public Classe GetById(int id)
        {
            using (var context = new DataContext())
            {
                var classe = context.Classe.FirstOrDefault(x => x.ClasseId == id);

                return classe;
            }
        }

        public int Post(Classe classe)
        {
            using (var context = new DataContext())
            {
                context.Classe.Add(classe);
                context.SaveChanges();

                return classe.ClasseId;
            }
        }
    }
}
