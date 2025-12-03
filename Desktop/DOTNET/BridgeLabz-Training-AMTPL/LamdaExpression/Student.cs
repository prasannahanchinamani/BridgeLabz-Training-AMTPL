using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.LamdaExpression
{
    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
   
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
        {
            new Student { RollNo = 1, Name = "Muttu" },
            new Student { RollNo = 3, Name = "Prasanna" },
            new Student { RollNo = 2, Name = "Prajwal" },
            new Student { RollNo = 4, Name = "Vinay" },
            new Student { RollNo = 5, Name = "Trisha" }
        };

            var sortedList = students.OrderBy(x => x.Name);

            foreach (var s in sortedList)
                Console.WriteLine($"{s.RollNo} {s.Name}");

            var sortedBasedOnRollNumber=students.OrderBy(x => x.RollNo);
            foreach (var s in sortedBasedOnRollNumber)
                Console.WriteLine($"{s.RollNo} {s.Name}");



            Func<int, int> sqaure = x => x * x;
            Console.WriteLine(sqaure(2));


            Action<int> consume = x => Console.WriteLine("Consumer");

            Predicate<int> resToF = x => x % 2 == 0;
            Console.WriteLine($"Is Even  {resToF(2)} ");
        }
    }
}
