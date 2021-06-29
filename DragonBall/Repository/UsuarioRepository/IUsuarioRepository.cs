using DragonBall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonBall.Repository.UsuarioRepository
{
    public interface IUsuarioRepository
    {
        IEnumerable<Usuario> Get();
        Usuario GetById(int id);
        Usuario Post(Usuario usuario);
    }
}
