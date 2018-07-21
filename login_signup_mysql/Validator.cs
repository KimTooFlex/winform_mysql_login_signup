using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace login_signup_mysql
{
    class Validator
    {
        internal static bool isValidName(string text)
        {
            return text.Trim().Length > 0;
        }

        internal static bool isValidUsernameName(string text)
        {
            if(text.Contains(" "))
            {
                return false;
            }



            //CHECK IF THE USERNAME IS TAKEN IN MYSQL DB



            return text.Trim().Length > 0;
        }

        internal static bool isValidEmail(string email)
        {
            //regenx works better
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
           + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
           + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";



            //CHECK IS THE EMAIL IS TAKEN  IN DB





            return new Regex(validEmailPattern, RegexOptions.IgnoreCase).IsMatch(email);

            
        }

        internal static bool isValidPassword(string text)
        {
            if (text.Contains(" "))
            {
                return false;
            }
            return text.Trim().Length > 5;
        }
    }
}
