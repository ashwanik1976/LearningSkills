using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstWebAPI
{
    public class EmployeeSecurity
    {
        public static bool Login(string userName, string password)
        {
            if (userName.Equals(userName, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}