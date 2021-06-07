using DragonBall.Data;
using System.Linq;
namespace DragonBall.Models
{
    public class VerificarPersonagem
    {
        public static bool VerificaNomePersonagem(DataContext dc, string NomePersonagem)
        {

            // var existeNomePersonagem = (from u in dc.Personagem
            //                             where u.Nome == NomePersonagem
            //                             select u).FirstOrDefault();

            NomePersonagem = NomePersonagem.Trim();
            NomePersonagem = NomePersonagem.ToLower();

            var existeNomePersonagem = dc.Personagem.FirstOrDefault(x => x.Nome == NomePersonagem);


            if (existeNomePersonagem != null)
                return true;
            else
                return false;

        }
    }
}
