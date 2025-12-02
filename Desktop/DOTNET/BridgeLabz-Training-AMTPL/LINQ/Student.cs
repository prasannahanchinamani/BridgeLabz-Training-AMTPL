using System;
using System.Collections.Generic;
using System.Linq;

namespace BridgeLabz_Training_AMTPL.LINQ
{
    internal class Student
    {
      
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Branch { get; set; }

     
        public static List<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student { Id = 1, Name = "Bill", Age = 15, Branch = "CSE" },
                new Student { Id = 2, Name = "Steve", Age = 22, Branch = "ECE" },
                new Student { Id = 3, Name = "James", Age = 18, Branch = "CSE" },
                new Student { Id = 4, Name = "Mohan", Age = 19, Branch = "ME" },
                new Student { Id = 5, Name = "Sara", Age = 12, Branch = "IT" }
            };
        }

        static void Main(string[] args)
        {
            List<Student> studentList = Student.GetStudents();
            //method syntax
            var studnet = studentList.ToArray();
            foreach (var student in studnet)
            {
                Console.WriteLine($"studentName,{student.Name}  studnet Age+{student.Age}");
            }
            //method syntax
             List<Student> studentListWhithBranchCse=studentList.Where(n=>n.Branch.Equals("CSE",StringComparison.OrdinalIgnoreCase)).ToList();
            //query syntax
            List<Student>studnetWithBrancCseq=(from n in studentList
                                             where n.Branch.Equals("CSE",StringComparison.OrdinalIgnoreCase)
                                             select n).ToList();
            foreach(var student in studnetWithBrancCseq)
            {
                Console.WriteLine(student.Name+"  "+student.Branch );
            }
        }
    }
}