using MvcSecurityExample.Models;
using MvcSecurityExample.Security;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace MvcSecurityExample
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
        /// <summary>
        /// /Bu kodu ben yazdım
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected  void Application_PostAuthenticateRequest(Object sender,EventArgs e)
        {
            HttpCookie httpCookie = Request.Cookies[FormsAuthentication.FormsCookieName];
            if (httpCookie!=null)
            {
                FormsAuthenticationTicket formsAuthenticationTicket = FormsAuthentication.Decrypt(httpCookie.Value);
                Account account = JsonConvert.DeserializeObject<Account>(formsAuthenticationTicket.UserData);
                MyPrincipal myPrincipal = new MyPrincipal(account.username);
                myPrincipal.Account = account;
                HttpContext.Current.User = myPrincipal;
            }
        }
    }
}
