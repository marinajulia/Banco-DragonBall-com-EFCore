using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonBall.Services
{
    public static class PasswordService
    {
        public static string Criptografar(string senha)
        {
            Chilkat.Crypt2 crypt = new Chilkat.Crypt2();
            crypt.HashAlgorithm = "md5";
            crypt.EncodingMode = "hex";

            return crypt.HashStringENC(senha);
        }
    }
}
