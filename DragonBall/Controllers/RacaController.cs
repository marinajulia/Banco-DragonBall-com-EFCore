using System.Collections.Generic;
using System.Threading.Tasks;
using DragonBall.Data;
using DragonBall.Models;
using DragonBall.Repository.RacaRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DragonBall.Controllers
{
    [ApiController]
    [Route("v1/racas")]
    public class RacaController : ControllerBase
    {
        private readonly IRacaRepository _racaRepository;

        public RacaController(IRacaRepository racaRepository)
        {
            _racaRepository = racaRepository;
        }

        [HttpGet]
        [Route("")]

        public ActionResult Get()
        {
            var raca = _racaRepository.Get();
            return Ok(raca);
        }


        [HttpPost]
        [Route("")]

        public async Task<ActionResult<Raca>> Post(
            [FromServices] DataContext context,
            [FromBody] Raca model)
        {
            if (ModelState.IsValid)
            {
                if (!VerificarRaca.VerificaNomeRaca(context, model.Nome))
                {
                    context.Raca.Add(model);
                    await context.SaveChangesAsync();
                    return model;

                }
                else
                {
                    return BadRequest("O nome informado já foi cadastrado");
                }

            }
            else
            {
                return BadRequest(ModelState);
            }

        }

        [HttpGet("finbyid")]
        public IActionResult GetById(int id)
        {
            var raca = _racaRepository.GetById(id);
            if (raca == null)
                return BadRequest("A Raça não pode ser encontrada");

            return Ok(raca);
        }


    }
}
