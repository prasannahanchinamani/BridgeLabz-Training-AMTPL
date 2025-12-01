using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BridgeLabz_Training_AMTPL.RegexExp
{
    internal class ValidateEmail
    {
        public static Boolean IsValidEmail(String email)
        {
            String pattern = @"^[a-zA-z0-9.-_+]+@[Gg]mail\.com$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);

        }
        public  static void ReplaceString(String x)
        {
            //Regex regex = new Regex(x);
            string result = Regex.Replace(x, "\\d", "");
            Console.WriteLine(result); 
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Email ID:");
            string email = Console.ReadLine();
            if (!IsValidEmail(email))
            {
                Console.WriteLine("Invalid Email ID. Please enter a valid Gmail address.");
            }
            else
            {
                Console.WriteLine("Valid Email ID.");
            }
            
            Console.WriteLine("Enter a string with numbers to replace:");
            string inputString = Console.ReadLine();
            ReplaceString(inputString);
        }
    }
}
