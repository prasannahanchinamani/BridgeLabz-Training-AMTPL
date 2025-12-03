using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.Delegates
{
    public delegate void LogDelegate(string message);

    class Logger
    {
        public static void LogToConsole(string msg)
        {
            Console.WriteLine("Console: " + msg);
        }

        public static void LogToFile(string msg)
        {

            Console.WriteLine("File: " + msg);
        }
    }
    internal class DelegateExample
    {
         public static void Main()
        {
            LogDelegate log = Logger.LogToConsole;
            log += Logger.LogToFile;

            log("Hello!");
        }
    }
}
