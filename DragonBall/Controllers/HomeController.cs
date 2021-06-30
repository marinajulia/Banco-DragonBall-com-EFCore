using DragonBall.Models;
using DragonBall.Repository.UsuarioRepository;
using DragonBall.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace DragonBall.Controllers {
    [Route("v1/account")]
    public class HomeController : ControllerBase 
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public HomeController(IUsuarioRepository usuarioRepository) 
        {
            _usuarioRepository = usuarioRepository;
        }

       

        [HttpGet]
        public IActionResult Get() 
        {
            try
            {
                var usuarios = _usuarioRepository.Get();

                if (usuarios == null && !usuarios.Any())
                    return BadRequest("Nenhum usuário foi encontrado");

                return Ok(usuarios);
            }
            catch (Exception e) {

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

        public ActionResult Post(Usuario model) 
        {
            try 
            {
                if (!ModelState.IsValid)
                    var teste = _usuarioRepository.Get
                    var usuarios = _usuarioRepository.Get();

                return Ok("test");
                else
                {
                    return BadRequest(ModelState);

                }
            }
            catch (Exception e) 
            {
                return BadRequest(e.Message);
            }

        }

    }
}
