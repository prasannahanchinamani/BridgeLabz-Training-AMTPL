using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceConcepts.Oops
{
   
        public class AgeValidation
        {
            private int age;
          public int Age
            {
                get { return age; } //getter
                set  //settet
                {
                    if(value>0 && value < 100)
                    {
                        age = value;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid age between 1 and 99.");
                    }
                }
            }
        }
    }

