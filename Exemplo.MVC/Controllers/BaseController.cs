using Exemplo.Domain.Entities;
using Exemplo.Domain.Interfaces.Services;
using Exemplo.MVC.Helpers;
using System;
using System.Web.Mvc;

namespace Exemplo.MVC.Controllers
{
    //[VerifyAccessActionFilter]
    //[OutputCache(NoStore = true, Duration = 0)]

    public class BaseController : Controller
    {
        private readonly ILogService _logService;

        public BaseController(ILogService logService)
        {
            _logService = logService;
        }

        public void SalvarCookie(string idCliente)
        {
            var newCookieHelper = new CookieHelper(HttpContext.Request, HttpContext.Response);
            newCookieHelper.SetLoginCookie("IdCliente", idCliente, true);
        }

        public int ObterIdClienteLogado()
        {
            var newCookieHelper = new CookieHelper(HttpContext.Request, HttpContext.Response);

            bool logado = System.Web.HttpContext.Current.User.Identity.IsAuthenticated;

            if (logado)
            {
                var idUsuario = newCookieHelper.Descriptografar(
                      Request.Cookies["IdCliente"].Value);

                return Convert.ToInt32(idUsuario);
            }

            return 0;
        }

        public void SaveLog(Exception ex)
        {
            var log = new Log
            {
                IdAcao = Convert.ToInt32(Log.Acao.Login),
                IP = Util.GetIp(HttpContext),
                Browser = Util.GetBrowser(HttpContext),
                Mensagem = string.Format("Gestão - {0},{1},{2}",
                                        ex.Message,
                                        ex.StackTrace,
                                        ex.InnerException != null ? ex.InnerException.Message : "")
            };

            _logService.Cadastrar(log);
        }

        public JsonResult RetornoPadrao(Exception ex)
        {
            return Json(new
            {
                StatusCode = 500,
                Erro = ex.Message,
                StackTrace = ex.StackTrace,
                InnerException = ex.InnerException != null ? ex.InnerException.Message : ""
            }, JsonRequestBehavior.AllowGet);

        }


    }
}