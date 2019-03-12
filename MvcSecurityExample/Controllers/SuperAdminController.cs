using MvcSecurityExample.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcSecurityExample.Controllers
{
    [MyAuthorizeAttribute(Roles = "superadmin")]
    public class SuperAdminController : Controller
    {
        // GET: SuperAdmin
        public ActionResult Index()
        {
            return View();
        }
    }
}