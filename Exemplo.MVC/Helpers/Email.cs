using Exemplo.Domain.Entities;
using Exemplo.Domain.Interfaces.Services;
using System;
using System.Configuration;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Threading;

namespace Exemplo.MVC.Helpers
{
    public class Email : IEmail
    {

        private string _urlBase = string.Empty;
        public void Enviar(Product product)
        {
            var site = new Util();
            var url = site.ObterUrlBase("/Content/assets/images/email/esqueciSenha");

            var template = Template("bruno.santos@g2it.com.br", product.Description, product.Price, url);

            EnviarEmail("bruno.santos@g2it.com.br", template, "Bruno, foi inserido um novo produto com descrição :" + product.Description);
        }

        private static string Template(string email, string descriptionProduct, decimal price, string url)
        {
            return Resources.EmailResources.createdProduct;
        }

        private static void EnviarEmail(string destinatario, string corpo, string subject)
        {
            var mm = new MailMessage { Body = corpo, Subject = subject, From = new MailAddress("contato@adagency.com.br", "Ad.Agency") };
            mm.To.Add(destinatario);
            mm.IsBodyHtml = true;

            var smtp = new SmtpClient
            {
                Host = ObterHost(),
                Port = ObterPorta(),
                EnableSsl = ConfigurationManager.AppSettings["mailEnableSsl"] != null && ConfigurationManager.AppSettings["mailEnableSsl"].ToString(CultureInfo.InvariantCulture).Equals("true") ? true : false,
                Credentials = new NetworkCredential(ConfigurationManager.AppSettings["mailLogin"].ToString(CultureInfo.InvariantCulture), ConfigurationManager.AppSettings["mailPassword"].ToString(CultureInfo.InvariantCulture))
            };

            new Thread(t => smtp.Send(mm)).Start();
        }

        private static string ObterHost()
        {
            return ConfigurationManager.AppSettings["mailHost"].ToString(CultureInfo.InvariantCulture);
        }

        private static int ObterPorta()
        {
            return Convert.ToInt32(ConfigurationManager.AppSettings["mailPort"].ToString(CultureInfo.InvariantCulture));
        }
    }
}