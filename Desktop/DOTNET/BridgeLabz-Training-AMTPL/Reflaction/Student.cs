using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.Reflaction
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public   void StudentInfo()
        {
            Console.WriteLine($"Studnet Id: {Id},Name: {Name}");
        }
        public static void Info()
        {
            Console.WriteLine("Information about Students");
        }
        public static void Main(string[] args)
        {
            Type type=typeof(Student);

            Console.WriteLine($"Info:{type.Name},{type.GetType}");
            foreach (var field in type.GetFields())
                Console.WriteLine("Field: " + field.Name);

            //foreach (var method in type.GetMethods())
            //    Console.WriteLine("Method: " + method.Name);

            foreach (var method in type.GetMethods(BindingFlags.Static|BindingFlags.Public| BindingFlags.DeclaredOnly))
                Console.WriteLine("Method: " + method.Name);
        }
    }
}
