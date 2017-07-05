using System.Web;
using System.Web.Mvc;

namespace Exemplo.MVC.Helpers
{
    public class Util
    {
        public static string GetIp(HttpContextBase context)
        {
            return context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] ?? context.Request.UserHostAddress;
        }

        public static string GetBrowser(HttpContextBase context)
        {
            HttpBrowserCapabilitiesBase browser = context.Request.Browser;
            return browser.Type;
        }

        public static string NormalizaLocalidade(string localidade)
        {
            switch (localidade)
            {
                case "SãoPaulo":
                    return "São Paulo";
                case "DistritoFederal":
                    return "Distrito Federal";
                case "EspíritoSanto":
                    return "Espírito Santo";
                case "MinasGerais":
                    return "Minas Gerais";
                case "MatoGrossodoSul":
                    return "Mato Grosso do Sul";
                case "MatoGrosso":
                    return "Mato Grosso";
                case "RiodeJaneiro":
                    return "Rio de Janeiro";
                case "RioGrandedoNorte":
                    return "Rio Grande do Norte";
                case "RioGrandedoSul":
                    return "Rio Grande do Sul";
                case "SantaCatarina":
                    return "Santa Catarina";
            }
            return localidade;
        }

        public string ObterUrlBase(string pastaProjeto)
        {
            var request = HttpContext.Current.Request;
            UrlHelper helper = new UrlHelper(HttpContext.Current.Request.RequestContext);
            var site = helper.Content("~" + pastaProjeto);

            return string.Format("{0}://{1}{2}", request.Url.Scheme, request.Url.Authority, site);
        }
    }
}