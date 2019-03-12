using MvcSecurityExample.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcSecurityExample.Controllers
{
    public class EmployeeController : Controller
    {
        [MyAuthorizeAttribute(Roles = "employee,admin,superadmin")]
        public ActionResult Index()
        {
            return View();
        }
    }
}