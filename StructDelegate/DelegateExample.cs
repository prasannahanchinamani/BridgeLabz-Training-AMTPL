using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL
{
    internal class DelegateExample
    {
        public delegate void exampleDelegate(string message);
        public delegate int exampleDelegate1(int a, int b);
        public void DisplayMeassage(string message)
        {
                       Console.WriteLine("Message: " + message);
        }
       
        public static  int AddNumbers(int a, int b)
        {
            return a + b;
        }
        public  static int AddThreeNumbers(int a, int b)
        {
            return a + b + 1;
        }
    }
}
