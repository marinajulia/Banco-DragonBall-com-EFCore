using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DragonBall.Data;
using DragonBall.Models;
using DragonBall.Repository.InfoRacaRepository;
using DragonBall.Repository.RacaRepository;
using System;

namespace DragonBall.Controllers
{
    [ApiController]
    [Route("v1/InfoRaca")]
    public class InfoRacaController : ControllerBase
    {
        private readonly IInfoRacaRepository _infoRacaRepository;
        private readonly IRacaRepository _racaRepository;
        public InfoRacaController(IInfoRacaRepository infoRacaRepository, IRacaRepository racaRepository)
        {
            _infoRacaRepository = infoRacaRepository;
            _racaRepository = racaRepository;

        }

        [HttpGet]
        public ActionResult Get()
        {
            var infoRacas = _infoRacaRepository.Get();
            return Ok(infoRacas);
        }

        [HttpGet("findbyid")]
        public ActionResult GetById(int id)
        {
            var infoRaca = _infoRacaRepository.GetById(id);
            if (infoRaca == null)
                return BadRequest("A Raça não pode ser encontrada");

            return Ok(infoRaca);
        }


        [HttpPost]
        public ActionResult Post(InfoRaca infoRaca)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            else
            {
                try
                {
                    var raca = _racaRepository.GetById(infoRaca.RacaId);
                    if (raca == null) return BadRequest("Raca não existe");
                    var infoRacas = _infoRacaRepository.Post(infoRaca);
                    return Ok(infoRacas);
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex);
                    return BadRequest("A classe já está cadastrada");
                }


            }

        }

        // [HttpGet]
        // [Route("InfoRaca/{id:int}")]

        // public async Task<ActionResult<List<InfoRaca>>> GetByIdCategory([FromServices] DataContext context, int id)
        // {
        //     var infoRaca1 = await context.InfoRaca
        //     .Include(x => x.Raca)
        //     .AsNoTracking()
        //     .Where(x => x.RacaId == id).ToListAsync();
        //     return infoRaca1;
        // }

    }
}
