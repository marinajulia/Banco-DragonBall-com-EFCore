using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DragonBall.Data;
using DragonBall.Models;

namespace DragonBall.Controllers
{
    [ApiController]
    [Route("v1/InfoRaca")]
    public class InfoRacaController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<InfoRaca>>> Get([FromServices] DataContext context)
        {
            var infoRacas = await context.InfoRaca.Include(x => x.Raca).ToListAsync();
            return infoRacas;
        }

        [HttpGet]
        [Route("{id:int}")]

        public async Task<ActionResult<InfoRaca>> GetById([FromServices] DataContext context, int id)
        {
            var infoRaca = await context.InfoRaca.Include(x => x.Raca)
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.InfoRacaId == id);
            return infoRaca;
        }

        [HttpGet]
        [Route("InfoRaca/{id:int}")]

        public async Task<ActionResult<List<InfoRaca>>> GetByIdCategory([FromServices] DataContext context, int id)
        {
            var infoRaca1 = await context.InfoRaca
            .Include(x => x.Raca)
            .AsNoTracking()
            .Where(x => x.RacaId == id).ToListAsync();
            return infoRaca1;
        }

        [HttpPost]
        [Route("")]

        public async Task<ActionResult<InfoRaca>> Post(
            [FromServices] DataContext context,
            [FromBody] InfoRaca model)
        {
            if (ModelState.IsValid)
            {
                context.InfoRaca.Add(model);
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
