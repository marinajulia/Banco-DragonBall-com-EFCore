using DragonBall.Models;
using System.Collections.Generic;

namespace DragonBall.Repository.UsuarioRepository {
    public interface IUsuarioRepository {
        IEnumerable<Usuario> Get();
        Usuario Post(Usuario usuario);

    }
}
