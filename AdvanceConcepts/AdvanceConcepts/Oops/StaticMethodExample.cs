using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceConcepts.Oops
{
    public class StaticMethodExample
    {
        // Static method
        public static void Greet()
        {
            Console.WriteLine("Hello from the static method!");
        }
        // Instance method
        public void DisplayMessage()
        {
            Console.WriteLine("Hello from the instance method!");
        }
    }
}
