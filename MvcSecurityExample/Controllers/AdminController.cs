using MvcSecurityExample.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSecurityExample.Controllers
{
    [MyAuthorizeAttribute(Roles ="admin,superadmin")]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}