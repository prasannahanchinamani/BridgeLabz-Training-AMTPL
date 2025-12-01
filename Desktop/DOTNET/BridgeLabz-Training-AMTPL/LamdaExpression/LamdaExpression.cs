using System;

namespace BridgeLabz_Training_AMTPL.LambdaExpression
{
    internal class LamdaExpression
    {
        public static Func<int, int> squareFunc = x => x * x;
        public  static int add(int x, int y) => x + y;

        public static void Main(string[] args)
        {
            Console.WriteLine($"Using :{squareFunc(5)}");
            delegateExample.calculate cal = add;
            int res = cal(3, 5);
            Console.WriteLine($"Result:{res}");
            int factor = 10; 

            Func<int, int> multiply = x => x * factor; 

            Console.WriteLine(multiply(5));
        }
    }
    internal class delegateExample
    {
        public delegate int calculate(int x, int y);
       
    }
}