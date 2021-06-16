using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DragonBall.Models;
using Microsoft.AspNetCore.Mvc;

namespace DragonBall.Repository.ClasseRepository
{
    public interface IClasseRepository
    {
        IEnumerable<Classe> Get();
        Classe GetById(int id);
        int Post(Classe classe);
    }

}
