using BridgeLabz_Training_AMTPL.FileIo.CSV;
using System;
using System.Text.Json;
using System.IO;
namespace BridgeLabz_Training_AMTPL.FileIo.JSON
{
    internal class ReadingJsonFile
    {
        static String file = @"C:\\Users\\User\\Desktop\\DOTNET\\BridgeLabz-Training-AMTPL\\FileIo\JSON";
        static string filePath = Path.Combine(file, "Student.json");
        public static void Main(string[] args)
        {
            FileStream file = new FileStream(filePath, FileMode.Open);
            List<Student>students=JsonSerializer.Deserialize<List<Student>>(file);
            foreach (var s in students)
            {
                Console.WriteLine($"{s.Id} {s.Name} {s.Marks}");
            }
        }
    }
}
