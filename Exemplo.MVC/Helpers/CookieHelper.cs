using System;
using System.Web;
using System.Web.Security;

namespace Exemplo.MVC.Helpers
{
    public sealed class CookieHelper
    {
        public HttpResponseBase Response { get; set; }
        public HttpRequestBase Request { get; set; }

        public CookieHelper(HttpRequestBase request, HttpResponseBase response)
        {
            Request = request;
            Response = response;
        }

        public void SetLoginCookie(string userName, string userData, bool isPermanentCookie)
        {
            if (Response == null) return;

            if (isPermanentCookie)
            {
                var dataLimiteCookie = DateTime.Now.AddDays(5);
                var userAuthTicket = new FormsAuthenticationTicket(1, userName, DateTime.Now, dataLimiteCookie, true, userData, FormsAuthentication.FormsCookiePath);
                var encUserAthTicket = FormsAuthentication.Encrypt(userAuthTicket);
                var userAuthCookie = new HttpCookie(userName, encUserAthTicket);

                FormsAuthentication.SetAuthCookie(userName, true);

                if (userAuthTicket.IsPersistent)
                    userAuthCookie.Expires = userAuthTicket.Expiration;

                userAuthCookie.Path = FormsAuthentication.FormsCookiePath;
                Response.Cookies.Add(userAuthCookie);
            }
            else
            {
                FormsAuthentication.SetAuthCookie(userData, false);
            }
        }

        public string Descriptografar(string cookieValue)
        {
            return FormsAuthentication.Decrypt(cookieValue).UserData;
        }
    }
}