using System;
using System.Collections.Generic;
using System.Text;

namespace FlatmateFinders.Common
{
    //List of Error Message and Regex for Validation
    public static class ErrorList
    {
        public static string EmailError = "Invalid Email.";
        public static string PasswordError = "Invalid Password.";
        public static string NameError = " is required.  ";
        public static string EmailRegex = @"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$";
        public static string PWDRegex = @"^[A-Za-z0-9_!@#$%^&*()_\-+=[{\]};:<>|./?]{6,}$";

    }
}
