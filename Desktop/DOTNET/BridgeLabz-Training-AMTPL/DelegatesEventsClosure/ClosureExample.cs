using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.DelegatesEventsClosure
{
    internal class ClosureExample
    {
        public static void Main(string[] args)
        {
            var actions = new List<Action>();

            for (int i = 1; i <= 3; i++)
            {
                int temp = i;               // if i is not declared always  4 4 4 4     its captures the variaable not a valaue
                actions.Add(() => Console.WriteLine(temp));
            }

            foreach (var action in actions)
                action();
        }
    }

}
