using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceConcepts.Oops
{
    
        public class Addition
        {
            //add two integers
            public  virtual int Add(int a,int b)
            {
                return a + b;
            }
            //add three integers
            public  int Add(int a, int b,int c)
            {
                return a + b + c;
            }
        }
       class AddAndMultiplyWith5 : Addition
    {
        public override int Add(int a,int b)
        {
            return 5 * (a + b);
        }
    }
    
}
