using DragonBall.Data;
using DragonBall.Models;
using DragonBall.Services;
using System;
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

        public Usuario Post(Usuario usuario) {
            using (var context = new DataContext()) {
                var jaExiste = VerificarUsuario.VerificaNomeUsuario(context, usuario.UserName);
                if (jaExiste) {
                   
                   

                    return usuario;
                }
                else {
                    throw new Exception();
                }
            }
        }
    }
}
