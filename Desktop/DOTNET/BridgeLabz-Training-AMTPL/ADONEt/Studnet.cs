using System;

namespace BridgeLabz_Training_AMTPL.ADONEt
{
    public class Student
    {
        public int Roll_Number { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        static void Main()
        {
            var repo = new StudnetRepo();
            var student = new Student
            {
                Roll_Number = 4,
                Name = "Prasanna",
                Age = 25,
                Email = "prasanna@gmail.com"
            };
            repo.InsertData(student);
            //repo.UpdateStudent(3, "Prasanna", 23, "prasannagoto@gmail.com");
            //Console.WriteLine("Done.");

            repo.UpdateStudent(1, "Prasanna Updated", 39, "prasanna.new@gmail.com");
            Console.WriteLine("Done");

            repo.DeleteStudent(2);
            Console.WriteLine("Done");
            repo.DisplayStudents();

        }
    }
}
