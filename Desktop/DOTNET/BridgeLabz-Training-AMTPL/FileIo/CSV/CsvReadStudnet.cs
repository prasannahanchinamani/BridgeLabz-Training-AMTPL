using System;
using System.Collections.Generic;
using System.Xml.Linq;
//namespace BridgeLabz_Training_AMTPL.FileIo.CSV;
namespace BridgeLabz_Training_AMTPL.FileIo.CSV
{
    internal class CsvReadStudnet
    {
        public static void Main(string[] args)
        {
            List<Student> students = new()
        {
            new Student { Id = 1, Name = "John", Marks = 80 },
            new Student { Id = 2, Name = "Sara", Marks = 90 },
            new Student { Id = 3, Name = "Ravi", Marks = 88 }
        };
            String file = @"C:\\Users\\User\\Desktop\\DOTNET\\BridgeLabz-Training-AMTPL\\FileIo\CSV";
            string filePath = Path.Combine(file, "Student.csv");
         
            try
            {
                using StreamReader reader = new StreamReader(filePath);
                string header = reader.ReadLine();
                Console.WriteLine("Header: " + header);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                     string[] parts = line.Split(',');
                      int Id = int.Parse(parts[0]);
                      string Name = parts[1];
                     int Marks = int.Parse(parts[2]);
                    Console.WriteLine($"id,{Id},Name,{Name},Marks{Marks}");
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
       
        }
    }
}
