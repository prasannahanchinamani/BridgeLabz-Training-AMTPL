using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.Attributes
{
    internal class ObsoleteAttributes
    {
        [Obsolete]
        public static void Method1()
        {
            Console.WriteLine("Mrthod is not used");
        }
        public static void Main(string[] args)
        {
            //ObsoleteAttribute obs=new ObsoleteAttribute();
            Method1();
        }

    }
}
