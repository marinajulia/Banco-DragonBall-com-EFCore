using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DragonBall.Data;
using DragonBall.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DragonBall.Controllers
{
    [ApiController]
    [Route("v1/Personagem")]
    public class PersonagemController : ControllerBase
    {
        [HttpGet]
        [Route("")]

        public async Task<ActionResult<List<Personagem>>> Get([FromServices] DataContext context)
        {
            var personagens = await context.Personagem
            .Include(x => x.Raca)
            .Include(x => x.Classe)
            .ToListAsync();
            return personagens;
        }

        [HttpGet]
        [Route("{id:int}")]

        public async Task<ActionResult<Personagem>> GetById([FromServices] DataContext context, int id)
        {
            var personagem = await context.Personagem
            .Include(x => x.Raca)
            .Include(x => x.Classe)
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.RacaId == id);
            return personagem;
        }

        // [HttpGet]
        // [Route("Personagem/{id:int}")]
        // public async Task<ActionResult<List<Personagem>>> GetByIdCategory([FromServices] DataContext context, int id)
        // {
        //     var personagem1 = await context.Personagem
        //     .Include(x => x.Raca)
        //     .AsNoTracking()
        //     .Where(x => x.RacaId == id).ToListAsync();
        //     return personagem1;
        // }

        [HttpPost]
        [Route("")]

        public async Task<ActionResult<Personagem>> Post(
           [FromServices] DataContext context,
           [FromBody] Personagem model)
        {
            if (ModelState.IsValid)
            {
                var classeData = context.Classe.FirstOrDefault(x => x.ClasseId == model.ClasseId);
                if (classeData == null) return BadRequest("A classe informada não foi encontrada");


                var racadata = context.Raca.FirstOrDefault(x => x.RacaId == model.RacaId);
                if (racadata == null) return BadRequest("A raça informada não foi encontrada");

                context.Personagem.Add(model);
                await context.SaveChangesAsync();
                return model;
            }
            else
            {
                return BadRequest(ModelState);
            }
        }


    }
}
