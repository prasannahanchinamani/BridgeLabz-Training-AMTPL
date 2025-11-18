using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceConcepts.TypeConversion;
    public class ExplicitTypeCasting
    {
        public void DemonstrateExplicitCasting()
        {
            double doubleValue = 42.58;
             int intvalue = (int)doubleValue;
        int value = 100;
            Console.WriteLine("Correct conversion", Convert.ToDouble(value));
              Console.WriteLine($"Double Value: {doubleValue}");
              Console.WriteLine($"Integer Value (after explicit casting): {intvalue}");
              
                  
    }
    }

