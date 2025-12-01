//using BridgeLabz_Training_AMTPL.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.Reflaction
{
    [AttributeUsage(AttributeTargets.Method)]
    internal class CustomAttributesReflaction : Attribute
    {
        public string Info { get; set; }
        public CustomAttributesReflaction(string info)
        {
            Info = info;
        }
        public static void info()
        {
            Console.WriteLine($"Info method");
        }
    }
    internal class Calculation
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Calculation() { }

        [CustomAttributesReflaction("This is Add Method")]
        public int Add(int a, int b)
        {
            return a + b;
        }
        [CustomAttributesReflaction("This is a static information method")]
        public static void Info()
        {
            Console.WriteLine("Static method: Information about Calculator");
        }

    }
    internal class example
    {
        public static void Main(string[] args)
        {
            Type type = typeof(Calculation);
            object obj = Activator.CreateInstance(type);

            MethodInfo addMethod = type.GetMethod("Add", BindingFlags.Public | BindingFlags.Instance);
            int result = (int)addMethod.Invoke(obj, new object[] { 5, 7 });
            Console.WriteLine($"Add Result = {result}");

            MethodInfo infoMethod = type.GetMethod("Info", BindingFlags.Public | BindingFlags.Static);
            infoMethod.Invoke(null, null);

            foreach (var method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly))
            {
                var attrs = method.GetCustomAttributes(typeof(CustomAttributesReflaction), false);
                foreach (CustomAttributesReflaction attr in attrs)
                {
                    Console.WriteLine($"Method: {method.Name} → Attribute Info: {attr.Info}");
                }
            }
            PropertyInfo[] properties = type.GetProperties();
             foreach (PropertyInfo prop in properties)
            {
                Console.WriteLine($"Property: {prop.Name}, Type: {prop.PropertyType}");
            }

        }

    }
}
