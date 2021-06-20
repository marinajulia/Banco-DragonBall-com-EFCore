using DragonBall.Data;
using System.Linq;
namespace DragonBall.Models
{
    public class VerificarInfoRaca
    {
        public static bool VerificaIdRaca(DataContext dc, int idRaca)
        {

            var existeIdRaca = (from u in dc.InfoRaca
                                where u.RacaId == idRaca
                                select u).FirstOrDefault();

            if (existeIdRaca != null)
                return true;
            else
                return false;

        }
    }
}
