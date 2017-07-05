using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace Exemplo.Domain.Services
{
    public class ToolsService
    {
        public string Criptografar(string texto)
        {
            var md5 = MD5.Create();
            var inputBytes = Encoding.ASCII.GetBytes(texto);
            var hash = md5.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            foreach (byte t in hash)
                sb.Append(t.ToString("x2"));

            return sb.ToString();
        }

        public List<string> PopularErros(ValidationResult resultado)
        {
            var erros = new List<string>();

            foreach (var erro in resultado.ErrorMessage)
            {
                erros.Add(erro.ToString());
            }

            return erros;
        }
    }
}
