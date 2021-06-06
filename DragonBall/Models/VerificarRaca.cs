using DragonBall.Data;
using System.Linq;
namespace DragonBall.Models
{
    public class VerificarRaca
    {
        public static bool VerificaNomeRaca(DataContext dc, string NomeRaca)
        {

            var existeNomeRaca = (from u in dc.Raca
                                  where u.Nome == NomeRaca
                                  select u).FirstOrDefault();

            if (existeNomeRaca != null)
                return true;
            else
                return false;

        }
    }
}
