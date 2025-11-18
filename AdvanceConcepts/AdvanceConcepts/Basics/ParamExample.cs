using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class ParamExample
    {
    
        public void DisplayNumbers(params int[] numbers)
        {
            Console.WriteLine("Numbers passed:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }

