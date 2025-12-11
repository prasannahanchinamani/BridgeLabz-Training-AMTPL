using System;
using System.IO;

namespace BridgeLabz_Training_AMTPL.FileIo
{
    internal class WriteFileExample
    {
        public static void Main(string[] args)
        {
           
            string path = @"C:\Users\User\Desktop\DOTNET\BridgeLabz-Training-AMTPL\FileIo";
            Directory.CreateDirectory(path);
            String filePath = Path.Combine(path, "WriteTxt.txt");

            File.WriteAllText(filePath,"Hello im Prasanna");
            string[] lines = {
            "Hello, I'm Prasanna",
                     "Doing great",
                       "Learning File I/O in C#"
                         };
            File.AppendAllLines(filePath, lines);


            using(StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("\n New Log Entry");
                writer.WriteLine(" This is all about");
            }

            DirectoryInfo directory = new DirectoryInfo(filePath);

            Console.WriteLine($"Info about directory: FullName={directory.FullName}, Parent={directory.Parent}");
            
            File.WriteAllLines(filePath,lines);

            StreamWriter writer1 = new StreamWriter(filePath, true);


            FileInfo fileInfo = new FileInfo(filePath);

           
            if (fileInfo.Exists)
            {
                Console.WriteLine($"File name: {fileInfo.Name}");
                Console.WriteLine($"Full path: {fileInfo.FullName}");
                Console.WriteLine($"Directory: {fileInfo.DirectoryName}");
                Console.WriteLine($"Size: {fileInfo.Length} bytes");
                Console.WriteLine($"Created: {fileInfo.CreationTime}");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }

            File.Move(filePath,"abc.txt");

        }
    }
}
