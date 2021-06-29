using DragonBall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonBall.Repository.UsuarioRepository {
    public interface IUsuarioRepository {
        IEnumerable<Usuario> Get();
        int Post(Usuario usuario);
    }
}
