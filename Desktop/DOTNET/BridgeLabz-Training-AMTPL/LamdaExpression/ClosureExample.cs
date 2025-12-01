using System;
namespace BridgeLabz_Training_AMTPL.LambdaExpression

//namespace BridgeLabz_Training_AMTPL.LamdaExpression
{
    internal class ClosureExample
    {
        int fact = 10;
        Func<int, int> square;

        public ClosureExample()
        {
            square = x => x * fact;
        }

        public int RunSquare(int x) => square(x); 

        public static void Main(string[] args)
        {
            ClosureExample obj = new();
            int res = obj.RunSquare(5);   
            Console.WriteLine($"Closure result: {res}");
        }
    }
}