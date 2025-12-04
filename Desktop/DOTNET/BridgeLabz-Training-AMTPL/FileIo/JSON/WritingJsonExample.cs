using System;
using System.Collections.Generic;
using System.Text.Json;
using BridgeLabz_Training_AMTPL.FileIo.CSV;

namespace BridgeLabz_Training_AMTPL.FileIo.JSON
{
    internal class WritingJsonExample
    {
          static String file = @"C:\\Users\\User\\Desktop\\DOTNET\\BridgeLabz-Training-AMTPL\\FileIo\JSON";
          static string filePath = Path.Combine(file, "Student.json");
        
        public static void Main(string[] args)
        {
            List<Student> students = new()
        {
            new Student { Id = 1, Name = "John", Marks = 80 },
            new Student { Id = 2, Name = "Sara", Marks = 90 },
            new Student { Id = 3, Name = "Ravi", Marks = 88 }
        };
            string? jsonFile = JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(filePath, jsonFile);

        }
    }
}
