using DragonBall.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;
namespace DragonBall.Models
{
    public class VerificarPersonagem
    {
        public static bool VerificaNomePersonagem(DataContext dc, string NomePersonagem)
        {
            NomePersonagem = NomePersonagem.Trim();

            var existeNomePersonagem = dc.Personagem.FirstOrDefault(x => x.Nome.ToLower() == NomePersonagem.ToLower());

            // var nome = dc.Personagem.FirstOrDefault(x => x.Nome == "PAo");
            // nome.Nome = nome.Nome.ToLower();
            // var teste = nome.Nome;

            if (existeNomePersonagem != null)
                return true;
            else
                return false;

        }
    }
}
