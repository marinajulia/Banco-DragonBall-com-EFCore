using DragonBall.Data;
using DragonBall.Models;
using DragonBall.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DragonBall.Repository.UsuarioRepository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuario Get(string username, string password)
        {
            using (var context = new DataContext())
            {
                var usuario = context.Usuario
                    .FirstOrDefault(x => x.UserName == username && x.Senha == password);
                return usuario;
            }
        }


        public UsuarioDto GetUser(string username, string senharecebida)
        {
            using (var context = new DataContext())
            {
                var Comparacaousuario = context.Usuario.FirstOrDefault(x => x.UserName == username && x.Senha == PasswordService.Criptografar(senharecebida));

                if (Comparacaousuario == null)
                    throw new Exception();

                return new UsuarioDto
                {
                    UserId = Comparacaousuario.UserId,
                    UserName = Comparacaousuario.UserName,
                    Role = Comparacaousuario.Role
                };
            }
        }


        public Usuario Post(Usuario usuario)
        {
            using (var context = new DataContext())
            {
                var jaExiste = VerificarUsuario.VerificaNomeUsuario(context, usuario.UserName);
                if (jaExiste)
                {
                    return usuario;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        public UsuarioDto PostCadastro(Usuario usuario)
        {
            using (var context = new DataContext())
            {
                var jaExiste = VerificarUsuario.VerificaNomeUsuario(context, usuario.UserName);
                if (!jaExiste)
                {
                    usuario.Senha = PasswordService.Criptografar(usuario.Senha);
                
                    context.Usuario.Add(usuario);
                    context.SaveChanges();

                    return new UsuarioDto
                    {
                        UserId = usuario.UserId,
                        UserName = usuario.UserName,
                        Role = usuario.Role
                    };

                }
                else
                {
                    throw new Exception();
                }
            }
        }
    }
}
