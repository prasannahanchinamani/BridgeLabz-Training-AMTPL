using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training_AMTPL.LINQ
{
    internal class InMemeoryLINQExaples
    {
        string[] names = { "Bill", "Steve", "James", "Mohan" };

        public  void LinqRun()
        {
            IEnumerable<string> myQuery = from name in names
                                          where name.Contains('a')
                                          select name;

            foreach (var n in myQuery)
            {
                Console.WriteLine(n);
            }
        }
        public void LamdaRun()
        {
            IEnumerable<string> myQuery = names.Where(n => n.Contains('a')).ToList();
            foreach (var name in myQuery)
            {
                Console.WriteLine(name);
            }

        }

        public static void Main()
        {
           InMemeoryLINQExaples ex=new InMemeoryLINQExaples();
            ex.LinqRun();
            Console.WriteLine("IN Lambda");
            ex.LamdaRun();
        }
    }
}
