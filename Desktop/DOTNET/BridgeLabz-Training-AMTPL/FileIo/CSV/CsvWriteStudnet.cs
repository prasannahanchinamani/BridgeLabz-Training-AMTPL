using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.FileIo.CSV
{
    internal class CsvWriteStudnet
    {
        public static void Main(string[] args)
        {
            List<Student> students = new()
            {
                new Student { Id = 1, Name = "Prasanna", Marks = 80 },
                new Student { Id = 2, Name = "Sara", Marks = 90 },
                new Student { Id = 3, Name = "Ravi", Marks = 88 },
                new Student { Id = 3, Name = "RaviKumar", Marks = 88 }
            };

            String file = @"C:\\Users\\User\\Desktop\\DOTNET\\BridgeLabz-Training-AMTPL\\FileIo\CSV";
            string filePath = Path.Combine(file, "Student.csv");

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Id,Name,Marks");
                foreach (var s in students)
                {
                    writer.WriteLine($"{s.Id},{s.Name},{s.Marks}");
                    Console.WriteLine($"{s.Id},{s.Name},{s.Marks}");
                }
            }
        }
    }
}
