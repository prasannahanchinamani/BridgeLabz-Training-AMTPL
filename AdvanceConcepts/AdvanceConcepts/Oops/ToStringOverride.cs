using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceConcepts.Oops
{
    public class ToStringOverride
    {
        private int id;
        private string name;
        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0)
                {
                    id = value;
                }
                else
                {
                    throw new ArgumentException("Id must be greater than 0");
                }
            }
        }
        public String Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    Console.Write("Name cannot be null or empty");
                }
            }
        }
            public override String ToString()
        {
            return $"Id: {Id},Name:{name}";
        }
        

    }
}
