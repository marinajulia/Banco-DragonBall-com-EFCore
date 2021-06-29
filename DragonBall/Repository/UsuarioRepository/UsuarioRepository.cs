using DragonBall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonBall.Repository.UsuarioRepository
{
    public static class UsuarioRepository
    {

        public static Usuario Get(string userName, string senha)
        {
            var usuarios = new List<Usuario>();
            return usuarios.Where(x => x.UserName.ToLower() == userName.ToLower() && x.Senha == x.Senha).FirstOrDefault();

        }

    }
}
