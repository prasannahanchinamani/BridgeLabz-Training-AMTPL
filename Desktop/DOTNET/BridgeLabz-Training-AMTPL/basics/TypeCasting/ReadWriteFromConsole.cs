using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceConcepts.basics
{
  public class ReadWriteFromConsole
    {
        public void ReadAndWrite()
        {
            Console.WriteLine("Enter Your First Name:"); //write on console
             String firstname=Console.ReadLine();
            Console.WriteLine("Enter Your  Last Name:"); //write on console
            String Lastname = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}", firstname, Lastname);

        }
    }
}
