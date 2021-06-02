using System.Collections.Generic;
using System.Threading.Tasks;
using DragonBall.Data;
using DragonBall.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DragonBall.Controllers
{
    [ApiController]
    [Route("v1/racas")]
    public class RacaController : ControllerBase
    {
        [HttpGet]
        [Route("")]

        public async Task<ActionResult<List<Raca>>> Get([FromServices] DataContext context)
        {
            var racas = await context.Raca.ToListAsync();
            return racas;
        }


        [HttpPost]
        [Route("")]

        public async Task<ActionResult<Raca>> Post(
            [FromServices] DataContext context,
            [FromBody] Raca model)
        {
            if (ModelState.IsValid)
            {
                context.Raca.Add(model);
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
