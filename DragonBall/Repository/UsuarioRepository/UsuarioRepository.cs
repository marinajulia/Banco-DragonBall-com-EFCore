using DragonBall.Data;
using DragonBall.Models;
using System.Collections.Generic;
using System.Linq;

namespace DragonBall.Repository.UsuarioRepository {
    public class UsuarioRepository : IUsuarioRepository {
        public IEnumerable<Usuario> Get()
        {
            using (var context = new DataContext())
            {
                var user = context.Usuario;
                return user.ToList();
            }

        }

        public int Post(Usuario usuario) {
            throw new System.NotImplementedException();
        }
    }
}
