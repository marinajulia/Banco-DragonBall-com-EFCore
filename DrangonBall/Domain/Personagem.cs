using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrangonBall.Domain {
    public class Personagem {
        public int Id { get; set; }

        public int RacaId { get; set; }

        public Raca Raca { get; set; }

        public int ClasseId { get; set; }

        public Classe Classe { get; set; }

        public string Nome { get; set; }

        public float PowerLevel { get; set; }

    }
}
