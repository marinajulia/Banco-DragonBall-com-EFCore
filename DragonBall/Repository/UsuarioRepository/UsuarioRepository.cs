using DragonBall.Data;
using DragonBall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonBall.Repository.UsuarioRepository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public IEnumerable<Usuario> Get()
        {
            using (var context = new DataContext())
            {
                var usuario = context.Usuario;
                return usuario.ToList();
            }
        }

        public Usuario GetById(int id)
        {
            using (var context = new DataContext())
            {
                var usuario = context.Usuario.FirstOrDefault(x => x.UserId == id);
                return usuario;
            }
        }

        public Usuario Post(Usuario usuario)
        {
            using (var context = new DataContext())
            {
                context.Usuario.Add(usuario);
                context.SaveChanges();

                return usuario;
            }
        }
    }
}
