using DomainValidation.Validation;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Exemplo.Domain.Interfaces.Services
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

        public List<string> FillInErrors(ValidationResult resultado)
        {
            var erros = new List<string>();

            foreach (var erro in resultado.Erros)
            {
                erros.Add(erro.Message);
            }

            return erros;
        }
    }
}
