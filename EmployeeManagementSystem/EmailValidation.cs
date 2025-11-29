using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class EmailValidation:Exception
    {
        public EmailValidation(string msg) : base(msg) { }
        public static bool IsValidEmail(String email)
        {
            //String pattern = @"^[a-zA-Z0-9._%+-]+@[Gg]mail\.com$";
            string pattern = @"^[a-zA-Z0-9._%+-]+@[Gg]mail\.com$";
            return Regex.IsMatch(email, pattern);
        }
    }
}
