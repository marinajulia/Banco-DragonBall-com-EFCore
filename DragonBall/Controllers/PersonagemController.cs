using System;
using DragonBall.Models;
using DragonBall.Repository.ClasseRepository;
using DragonBall.Repository.PersonagemRepository;
using DragonBall.Repository.RacaRepository;
using Microsoft.AspNetCore.Mvc;

namespace DragonBall.Controllers
{
    [ApiController]
    [Route("v1/Personagem")]
    public class PersonagemController : ControllerBase
    {
        private readonly IPersonagemRepository _personagemRepository;
        private readonly IRacaRepository _racaRepository;
        private readonly IClasseRepository _classeRepository;
        public PersonagemController(IPersonagemRepository personagemRepository,
        IRacaRepository racaRepository, IClasseRepository classeRepository)
        {
            _personagemRepository = personagemRepository;
            _racaRepository = racaRepository;
            _classeRepository = classeRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var personagens = _personagemRepository.Get();

            return Ok(personagens);
        }

        [HttpGet("findbyid")]
        public ActionResult GetById(int id)
        {
            var personagem = _personagemRepository.GetById(id);
            if (personagem == null)
                return BadRequest("O personagem não pode ser encontrado");

            return Ok(personagem);
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
        public ActionResult Post(Personagem personagem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                try
                {
                    var classe = _classeRepository.GetById(personagem.ClasseId);

                    if (classe == null)
                        return BadRequest("A classe não existe");

                    var raca = _racaRepository.GetById(personagem.RacaId);

                    if (raca == null)
                        return BadRequest("A classe não existe");

                    var nomePersonagem = _personagemRepository.GetByName(personagem.Nome);

                    if (nomePersonagem != null)
                        return BadRequest("Este personagem já existe");

                    var personagens = _personagemRepository.Post(personagem);

                    return Ok(personagens);

                }
                catch (Exception ex)
                {

                    System.Console.WriteLine(ex);
                    return BadRequest("Personagem já cadastrado");
                }
            }
        }

    }
}
