using BridgeLabz_Training_AMTPL.FileIo.CSV;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace BridgeLabz_Training_AMTPL.FileIo.JSON
{
    internal class ReadingJsonFile
    {
        static string folder =
            @"C:\Users\User\Desktop\DOTNET\BridgeLabz-Training-AMTPL\FileIo\JSON";

        static string filePath = Path.Combine(folder, "Student.json");

        static void Main()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("JSON file not found");
                return;
            }

            using FileStream fs = new FileStream(filePath, FileMode.Open);

            List<Student>? students =
                JsonSerializer.Deserialize<List<Student>>(fs);

            if (students == null)
            {
                Console.WriteLine("No data found in JSON");
                return;
            }

            foreach (var s in students)
            {
                Console.WriteLine($"{s.Id} {s.Name} {s.Marks}");
            }
        }
    }
}
