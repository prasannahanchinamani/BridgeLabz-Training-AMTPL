using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.FileIo
{
    internal class ReadExample
    {

        public static void Main(string[] args)
        {
            string filePath = @"C:\Users\User\Desktop\DOTNET\BridgeLabz-Training-AMTPL\FileIo\WriteTxt.txt";

            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);

            using (StreamReader reader = new StreamReader(filePath))
            {
                Console.WriteLine(reader.ReadLine());
            }

            Console.WriteLine(File.ReadAllText(filePath));

            string[] LineByLine = File.ReadAllLines(filePath);
            IEnumerable<string> lines = File.ReadLines(filePath);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            try
            {
                string content1 = File.ReadAllText("abc.txt");
                Console.WriteLine(content1);

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }


            if (File.Exists("Abc.txt"))
                {
                    File.Delete("Abc.txt");
                    Console.WriteLine("Deleted files");
                }
            }

        }
    }

