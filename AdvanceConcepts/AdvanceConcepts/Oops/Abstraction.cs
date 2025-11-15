using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceConcepts.Oops
{
  
        public abstract class Animalabstract
        {
            public abstract void MakeSound();
        }
       public class Dog1: Animalabstract 
        {
            public override void MakeSound()
            {
                Console.WriteLine(" Dog is Barking... ");
            }
        }
    }
