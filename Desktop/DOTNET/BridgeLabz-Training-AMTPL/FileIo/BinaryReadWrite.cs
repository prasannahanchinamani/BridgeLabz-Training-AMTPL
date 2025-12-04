using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.FileIo
{
    internal class BinaryReadWrite
    {
        public void Write()
        {
            using BinaryWriter writer = new BinaryWriter(File.Open("Abc.txt", FileMode.Create));
            writer.Write(0);
            writer.Write("Prasanna");
        }
        public void ReadFile()
        {
            using BinaryReader read = new BinaryReader(File.Open("Abc.txt", FileMode.Open));
            int a = read.ReadInt32();
            string name=read.ReadString();
            Console.WriteLine($"{a},{name}");
        }
        public static void Main(string[] args)
        {
            BinaryReadWrite brw = new BinaryReadWrite();
      
            brw.Write();
            brw.ReadFile();

        }
    }
}
