using System;
using System.ComponentModel;

namespace Exemplo.Domain.Entities
{
    public class Log
    {
        public int Id { get; set; }
        public int IdAcao { get; set; }
        public string IP { get; set; }
        public string Browser { get; set; }
        public string Mensagem { get; set; }
        public DateTime DataCadastro { get; set; }
        public int? IdResponsible { get; set; }
        public virtual Responsible Responsible { get; set; }

        public enum Acao
        {
            [Description("Efetuar Login do usuário")]
            DoClientLogin = 1,
            [Description("Cadastrar usuário")]
            RegisterUser = 2,
            [Description("Efetuar login")]
            Login = 3,
            [Description("Esqueci senha")]
            ForgotPassword = 4,
        }
    }
}
