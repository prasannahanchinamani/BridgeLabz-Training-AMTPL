using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceConcepts.Oops
{
        public interface IVehicle
        {
            void Start();
            void Stop();
        }
        class Car : IVehicle
    {
             public void Start()
            {
                Console.WriteLine("Car started.");
            }
            public void Stop()
            {
                Console.WriteLine("Car stopped.");
        }
   
    }
    }

