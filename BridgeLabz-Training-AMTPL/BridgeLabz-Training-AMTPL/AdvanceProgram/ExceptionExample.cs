using System;

namespace BridgeLabz_Training_AMTPL.AdvanceProgram
{
    public class ExceptionExample
    {
        public class InvalidAgeException : Exception
        {
            public InvalidAgeException(string message) : base(message) { }
        }
        public static void ValidateAge()
        { 
              Console.WriteLine("Enter your age:");
              int age = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (age < 18)
                {
                    throw new InvalidAgeException("Age must be Valid must be over 18 vote");
                }
            }catch(InvalidAgeException e)
            {
                Console.WriteLine($"Caught Exception,{e.Message}");
            }

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Age Validator ");
            ExceptionExample.ValidateAge();
             
        }
    }
}