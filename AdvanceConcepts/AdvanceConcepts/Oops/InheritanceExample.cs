using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceConcept.Oops
{
   
    public class Animal1
    {
        public void Eat()
        {
            Console.WriteLine(" Eating...");
        }
    }
    public class Doginheritance : Animal1
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }
    public class Cat : Animal1
    {
        public void Meow()
        {
            Console.WriteLine("Meowing...");
        }
    }
}
