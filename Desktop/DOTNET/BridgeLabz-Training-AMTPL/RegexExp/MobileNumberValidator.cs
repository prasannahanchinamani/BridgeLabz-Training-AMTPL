using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BridgeLabz_Training_AMTPL.RegexExp
{
    internal class MobileNumberValidator
    {
        public static void ValidateMobileNumber()
        {
            Console.WriteLine("Enter Mobile Number with Country Code:");
            string mobileNumber = Console.ReadLine();
            String pattern = @"^[0-9]{2}\d{8}$";
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(mobileNumber))
            {
                Console.WriteLine("Invalid Mobile Number. Please enter in the format: CCXXXXXXXXXX (e.g., 919876543210)");
            }
        }
        public static void Main(string[] args)
        {
            ValidateMobileNumber();
        }   
    }
}
