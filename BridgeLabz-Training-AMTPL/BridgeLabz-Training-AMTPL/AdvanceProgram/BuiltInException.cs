using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.AdvanceProgram
{
    public class BuiltInException
    {
        int[] a = { 1, 2, 3, 4 };
         
       public void BuiltInExceptionException()
        {
            try
            {
                for (int i = 0; i <= a.Length; i++)
                {
                    Console.WriteLine(a[i]);
                }
            }catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Main(string[] args)
        {
            BuiltInException example = new BuiltInException();
            example.BuiltInExceptionException();
        }
    }
}
