using System.Security.Cryptography;
using System.Text;

namespace ControleDeContatos.Helper
{
    public static class Criptografia
    {
        public static string GerarHash(this string valor)
        {
            var hash = SHA1.Create();
            var encode = new ASCIIEncoding();
            var array = encode.GetBytes(valor);

            array = hash.ComputeHash(array);

            var strHexa = new StringBuilder();

            foreach(char item in array)
            {
                strHexa.Append(item.ToString());
            }

            return strHexa.ToString();
        }
    }
}
