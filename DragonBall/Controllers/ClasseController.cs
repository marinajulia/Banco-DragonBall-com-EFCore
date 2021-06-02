using System.Collections.Generic;
using System.Threading.Tasks;
using DragonBall.Data;
using DragonBall.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DragonBall.Controllers
{
    [ApiController]
    [Route("v1/classes")]
    public class ClasseController : ControllerBase
    {
        [HttpGet]
        [Route("")]

        public async Task<ActionResult<List<Classe>>> Get([FromServices] DataContext context)
        {
            var classes = await context.Classe.ToListAsync();
            return classes;
        }


        [HttpPost]
        [Route("")]

        public async Task<ActionResult<Classe>> Post(
            [FromServices] DataContext context,
            [FromBody] Classe model)
        {
            if (ModelState.IsValid)
            {
                context.Classe.Add(model);
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
