using System;
using DragonBall.Models;
using DragonBall.Repository.RacaRepository;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Post(Raca raca)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var nomeRaca = _racaRepository.GetByName(raca.Nome);

                    if (nomeRaca != null)
                        return BadRequest("Esta raça já existe");

                    var racas = _racaRepository.Post(raca);
                    return Ok(raca);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex);
                    return BadRequest("A raça já existe");
                }

            }
            else
            {
                return BadRequest(ModelState);
            }

        }

        [HttpGet("findbyid")]
        public ActionResult GetById(int id)
        {
            var raca = _racaRepository.GetById(id);
            if (raca == null)
                return BadRequest("A Raça não pode ser encontrada");

            return Ok(raca);
        }


    }
}
