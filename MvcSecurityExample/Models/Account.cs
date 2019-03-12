using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSecurityExample.Models
{
    public class Account
    {
        public string username { get; set; }
        public string fullname { get; set; }
        public string role { get; set; }
        public Account()
        {

        }
        public Account(string username, string fullname, string role)
        {
            this.username = username;
            this.fullname = fullname;
            this.role = role;
        }
    }
}