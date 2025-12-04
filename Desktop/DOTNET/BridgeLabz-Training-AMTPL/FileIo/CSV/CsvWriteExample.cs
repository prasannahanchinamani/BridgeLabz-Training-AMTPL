using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.FileIo.CSV
{
    internal class CsvWriteExample
    {
        public static void Main(string[] args)
        {
            String file = @"C:\\Users\\User\\Desktop\\DOTNET\\BridgeLabz-Training-AMTPL\\FileIo\CSV";
            //Directory.CreateDirectory(file);
            string filePath = Path.Combine(file, "Student.csv");
            using StreamWriter writter = new StreamWriter(filePath);
            writter.WriteLine($"'Id','Name','Marks'");
            writter.WriteLine("1,Muttu,80");
            writter.WriteLine("2,Sara,90");
            writter.WriteLine("3,Ravi,88");
            Console.WriteLine("Csv Creates");

        }
    }
}
