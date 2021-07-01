using DragonBall.Models;
using DragonBall.Repository.UsuarioRepository;
using DragonBall.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace DragonBall.Controllers {
    [Route("v1/account")]
    public class HomeController : ControllerBase {
        private readonly IUsuarioRepository _usuarioRepository;

        public HomeController(IUsuarioRepository usuarioRepository) {
            _usuarioRepository = usuarioRepository;
        }


        [HttpGet]
        public IActionResult Get(string nome, string senha) {
            try 
            {
                var usuarios = _usuarioRepository.Get(nome, senha);

                if (usuarios == null)
                    return BadRequest("Nenhum usuário foi encontrado");

                return Ok(usuarios);
            }
            catch (Exception e) 
            {

                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("anonymous")]
        [AllowAnonymous]
        public string Anonymous() => "Anônimo";


        [HttpGet]
        [Route("authenticated")]
        [Authorize]
        public string Authenticated() => String.Format("Autenticado = {0}", User.Identity.Name);


        [HttpPost]
        [Route("login")]
        [AllowAnonymous]

        public ActionResult Post(Usuario model) {
            try {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var usuario = _usuarioRepository.Get(model.UserName, model.Senha);

                var token = TokenService.GenerateToken(usuario);
                usuario.Senha = null;


                return Ok(usuario);
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }

            //[HttpGet]
            //public IActionResult Get() 
            //{
            //    try
            //    {
            //        var usuarios = _usuarioRepository.Get();

            //        if (usuarios == null && !usuarios.Any())
            //            return BadRequest("Nenhum usuário foi encontrado");

            //        return Ok(usuarios);
            //    }
            //    catch (Exception e) {

            //        return BadRequest(e.Message);
            //    }
            //}

        }

    }
}