using System.Collections.Generic;
using System.Threading.Tasks;
using DragonBall.Data;
using DragonBall.Models;
using DragonBall.Repository.ClasseRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DragonBall.Controllers
{
    [ApiController]
    [Route("v1/classes")]
    public class ClasseController : ControllerBase
    {
        private readonly IClasseRepository _classeRepository;

        public ClasseController(IClasseRepository classeRepository)
        {
            _classeRepository = classeRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var classes = _classeRepository.Get();

            return Ok(classes);
        }


        [HttpPost]

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
        [HttpGet("findbyid")]
        public IActionResult GetById(int id)
        {
            var classe = _classeRepository.GetById(id);
            if (classe == null)
                return BadRequest("A classe não pode ser encontrada");

            return Ok(classe);
        }
    }
}
