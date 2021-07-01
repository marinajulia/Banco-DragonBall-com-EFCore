﻿using DragonBall.Data;
using DragonBall.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonBall.Repository.UsuarioRepository {
    public class UsuarioRepository : IUsuarioRepository {
        public Usuario Get(string username, string password) {
            using (var context = new DataContext()) {
                var usuario = context.Usuario
                    .FirstOrDefault(x => x.UserName == username && x.Senha == password);
                return usuario;
            }
        }

        public UsuarioDto GetUser(string username, string password)
        {
            using (var context = new DataContext())
            {
                var usuario = context.Usuario.FirstOrDefault(x => x.UserName == username && x.Senha == password);

                return new UsuarioDto
                {
                    UserId = usuario.UserId,
                    UserName = usuario.UserName,
                    Role = usuario.Role
                };
            }
        }


        //public IEnumerable<Usuario> GetUsuarios()
        //{
        //    using (var context = new DataContext())
        //    {
        //        var user = context.Usuario;
        //        return user.ToList();
        //    }

        //}


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
