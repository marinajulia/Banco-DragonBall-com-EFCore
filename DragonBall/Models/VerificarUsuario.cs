using DragonBall.Data;
using System.Linq;
namespace DragonBall.Models {
    public class VerificarUsuario {
        public static bool VerificaNomeUsuario(DataContext dc, string NomeUsuario) {

            var existeNomeUsuario = (from u in dc.Usuario
                                     where u.UserName == NomeUsuario
                                     select u).FirstOrDefault();

            if (existeNomeUsuario != null)
                return true;
            else
                return false;

        }
    }
}
