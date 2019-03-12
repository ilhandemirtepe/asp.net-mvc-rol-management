using MvcSecurityExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace MvcSecurityExample.Security
{
    public class MyPrincipal : IPrincipal
    {
        public Account  Account { get; set; }

        public IIdentity Identity
        {
            get;
            set;

        }

        public MyPrincipal(string username)
        {
            this.Identity = new GenericIdentity(username);

        }
        public bool IsInRole(string role)
        {
            var roles = role.Split(new char[] { ','});
            return roles.Any(r=>r.Equals(this.Account.role));

        }
    }
}