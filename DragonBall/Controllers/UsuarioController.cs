using DragonBall.Models;
using DragonBall.Repository.UsuarioRepository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonBall.Controllers
{
    [ApiController]
    [Route("v1/usuarios")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var usuario = _usuarioRepository.Get();

            return Ok(usuario);
        }

        [HttpPost]
        public ActionResult Post(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                var usuarios = _usuarioRepository.Post(usuario);

                return Ok(usuarios);
            }
            else
            {
                return BadRequest(ModelState);
            }

        }
        [HttpGet("findbyid")]
        public IActionResult GetById(int id)
        {
            var usuarios = _usuarioRepository.GetById(id);
            if (usuarios == null)
                return BadRequest("O usuário não pode ser encontrado");

            return Ok(usuarios);
        }

    }
}
