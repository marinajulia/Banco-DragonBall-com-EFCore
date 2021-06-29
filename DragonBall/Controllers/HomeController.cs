using DragonBall.Models;
using DragonBall.Repository.UsuarioRepository;
using DragonBall.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DragonBall.Controllers
{
    [Route("v1/account")]
    public class HomeController : ControllerBase
    {
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]

        public async Task<ActionResult<dynamic>> Authenticate([FromBody] Usuario model)
        {
            var usuario = UsuarioRepository.Get(model.UserName, model.Senha);
            if (usuario == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(usuario);
            usuario.Senha = "";
            return new
            {
                usuario = usuario,
                token = token

            };
        }

    }
}
