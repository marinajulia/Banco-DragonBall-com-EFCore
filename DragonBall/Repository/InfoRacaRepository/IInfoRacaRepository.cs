using System.Collections.Generic;
using DragonBall.Models;

namespace DragonBall.Repository.InfoRacaRepository
{
    public interface IInfoRacaRepository
    {
        IEnumerable<InfoRaca> Get();
        InfoRaca GetById(int id);
        InfoRaca Post(InfoRaca infoRaca);

    }
}
