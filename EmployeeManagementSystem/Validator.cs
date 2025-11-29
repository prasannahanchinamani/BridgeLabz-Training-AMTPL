using System.Text.RegularExpressions;

namespace EmployeeManagementSystem
{
    internal class Validator
    {
        public static int ReadId(string prompt)
        {
            int id;
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out id) && id > 0)
                {
                    return id;
                }
                else
                {
                    Console.WriteLine("ID must be greater than 0.");
                }
            }
        }

        public static string ReadName(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                    return input;
                else
                    Console.WriteLine("Name cannot be empty. Please try again.");
            }
        }

        public static string ReadEmail(string prompt)
        {
            while (true)
            {
                Console.WriteLine(prompt);
                string email = Console.ReadLine();

                //string pattern = "@\"^[a-zA-Z0-9._%+-]+@[Gg]mail\\.com$\"";
                string pattern = @"^[a-zA-Z0-9._%+-]+@[Gg]mail\.com$";

                try
                {
                    if (Regex.IsMatch(email, pattern))
                    {
                        return email;
                    }
                    else
                    {
                      
                        throw new EmailValidation("Invalid email format entered.");
                    }
                }
                catch (EmailValidation ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }
            }
        }


        public static double ReadSalary(string prompt)
        {
            double salary;
            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input, out salary) && salary > 0)
                {
                    return salary;
                }
                else
                {
                    Console.WriteLine("Salary must be a positive number greater than 0.");
                }
            }
        }
    }
}