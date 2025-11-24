using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceConcepts.TypeConversion
{
    public class ImplicitTypeCasting
    {
        public void DemonstrateImplicitCasting()
        {
            int intValue = 42;
            double doubleValue = intValue;
            Console.WriteLine($"Integer Value: {intValue}");
            Console.WriteLine($"Double Value (after implicit casting): {doubleValue}");

        }
    }
}
