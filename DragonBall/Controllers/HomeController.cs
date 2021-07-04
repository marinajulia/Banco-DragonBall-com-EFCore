using DragonBall.Models;
using DragonBall.Repository.UsuarioRepository;
using DragonBall.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DragonBall.Controllers {
    [Route("v1/account")]
    public class HomeController : ControllerBase {
        private readonly IUsuarioRepository _usuarioRepository;

        public HomeController(IUsuarioRepository usuarioRepository) {
            _usuarioRepository = usuarioRepository;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]

        public IActionResult Post(Usuario model)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var usuario = _usuarioRepository.GetUser(model.UserName, model.Senha);

                if (usuario == null)
                    return NotFound("Usuario e senha nâo encontrados");

                var token = TokenService.GenerateToken(usuario);

                return Ok(new
                {
                    usuario,
                    token
                });
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpPost]
        [Route("cadastro")]
        public ActionResult PostCadastro(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                var usuarios = _usuarioRepository.PostCadastro(usuario);

                return Ok(usuarios);
            }
            else
            {
                return BadRequest(ModelState);
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

    }
}

//[HttpGet]
//public IActionResult GetUsuarios()
//{
//    try
//    {
//        var usuarios = _usuarioRepository.GetUsuarios();

//        if (usuarios == null && !usuarios)
//            return BadRequest("Nenhum usuário foi encontrado");

//        return Ok(usuarios);
//    }
//    catch (Exception e)
//    {

//        return BadRequest(e.Message);
//    }
//}