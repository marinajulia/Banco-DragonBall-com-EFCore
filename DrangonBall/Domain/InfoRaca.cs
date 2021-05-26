using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrangonBall.Domain {
    public class InfoRaca {

        public int InfoRacaId { get; set; }

        public int RacaId { get; set; }

        public Raca Raca { get; set; }

        public string Descriçao { get; set; }


    }
}
