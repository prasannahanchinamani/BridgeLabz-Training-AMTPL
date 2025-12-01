using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    internal class CustomAttributes:Attribute
    {
        public String Info { get; }
        public CustomAttributes(string str)
        {
            Info = str;
        }
        public static void Main(string[] args)
        {
          Calculator calculator=new Calculator();
             int res=calculator.Add(2, 3);
            Console.WriteLine(res);
        }
    }
    internal class Calculator
    {
        [CustomAttributes("This method performs addition of two numbers")]
        public   int Add(int a, int b)
        {
            return a + b;
        }

   
    }

}
