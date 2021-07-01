using DragonBall.Models;
using DragonBall.Repository.ClasseRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
        [Authorize]
        public IActionResult Get()
        {
            var classes = _classeRepository.Get();

            return Ok(classes);
        }

        
        [HttpPost]
        [Authorize]
        public ActionResult Post(Classe classe)
        {
            if (ModelState.IsValid)
            {
                var classes = _classeRepository.Post(classe);

                return Ok(classes);
            }
            else
            {
                return BadRequest(ModelState);
            }

        }
        
        [HttpGet("findbyid")]
        [Authorize]
        public IActionResult GetById(int id)
        {
            var classe = _classeRepository.GetById(id);
            if (classe == null)
                return BadRequest("A classe não pode ser encontrada");

            return Ok(classe);
        }
    }
}
