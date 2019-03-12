using MvcSecurityExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Newtonsoft.Json;
namespace MvcSecurityExample.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
          //  Account account = new Account("superadmin","Super Admin","superadmin");
             Account account = new Account("admin", "Admin", "admin");
            //Account account = new Account("employee", "Employee", "employee");

            FormsAuthenticationTicket formsAuthenticationTicket = new FormsAuthenticationTicket(1,"aac",DateTime.Now,DateTime.Now.AddMinutes(40),false,JsonConvert.SerializeObject(account));
            HttpCookie httpCookie = new HttpCookie(FormsAuthentication.FormsCookieName, FormsAuthentication.Encrypt(formsAuthenticationTicket));
            httpCookie.Expires = DateTime.Now.AddMinutes(15);
            Response.Cookies.Add(httpCookie);


            return View();
        }
    }
}