using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL
{
    internal class StruckExample
    {
        public struct position
        {
            private int _x;
            private int _y;
            public position(int X, int Y)
            {
                _x = X;
                _y = Y;
            }
            public void display()
            {
                Console.WriteLine("X = " + _x + " Y = " + _y);

            }
          
        }
    }
}
