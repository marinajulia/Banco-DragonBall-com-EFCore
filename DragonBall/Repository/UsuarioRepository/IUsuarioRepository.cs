using DragonBall.Models;
using System.Collections.Generic;

namespace DragonBall.Repository.UsuarioRepository {
    public interface IUsuarioRepository {
        Usuario Get(string username, string password);
        //IEnumerable<Usuario> GetUsuarios();
        Usuario Post(Usuario usuario);
        Usuario PostCadastro(Usuario usuario);
        UsuarioDto GetUser(string username, string password);
    }
}
