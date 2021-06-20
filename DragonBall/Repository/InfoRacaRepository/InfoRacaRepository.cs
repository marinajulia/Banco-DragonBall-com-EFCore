using System;
using System.Collections.Generic;
using DragonBall.Data;
using DragonBall.Models;

namespace DragonBall.Repository.InfoRacaRepository
{
    public class InfoRacaRepository : IInfoRacaRepository
    {
        public IEnumerable<InfoRaca> Get()
        {
            throw new System.NotImplementedException();
        }

        public InfoRaca GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public InfoRaca Post(InfoRaca infoRaca)
        {
            using (var context = new DataContext())
            {
                var jaExiste = VerificarInfoRaca.VerificaIdRaca(context, infoRaca.RacaId);
                if (!jaExiste)
                {
                    context.InfoRaca.Add(infoRaca);
                    context.SaveChanges();
                    return infoRaca;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
    }
}

//verificação no controller
// var racadata = context.Raca.FirstOrDefault(x => x.RacaId == model.RacaId);
// if (racadata == null)
//     return BadRequest("A raça informada não foi encontrada");
// // var racas = _racaRepository.Get(raca);
// // context.InfoRaca.Add(model);
// // await context.SaveChangesAsync();
// // return model;
