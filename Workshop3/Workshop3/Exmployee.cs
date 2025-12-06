using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop3
{
    internal class Exmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
         public DateOnly DateOfBirth {  get; set; }
         public  DateTime JoingDate { get; set; }

        public String Department { get; set; }  
        public Double Salary { get; set; }
        public Exmployee(int id, string name, DateOnly dateOfBirth, DateTime joingDate, string department, double salary)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            JoingDate = joingDate;
            Department = department;
            Salary = salary;
        }

        public override string? ToString()
        {
            return $"id:{Id},name:{Name},DateOfBirth,{DateOfBirth},JoingDate{JoingDate},Department{Department},Salary{Salary}";
        }
    }
}
