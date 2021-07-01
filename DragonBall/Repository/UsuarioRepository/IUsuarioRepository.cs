using DragonBall.Models;
using System.Collections.Generic;

namespace DragonBall.Repository.UsuarioRepository {
    public interface IUsuarioRepository {
        Usuario Get(string username, string password);
        Usuario Post(Usuario usuario);

    }
}
