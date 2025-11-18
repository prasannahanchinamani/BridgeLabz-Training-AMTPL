using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceConcepts.Oops
{
 public class Parent
    {
        public string greeting = "Hello from Parent";
        public void Greet()
        {
            Console.WriteLine(greeting);
        }
    }
    public class Child : Parent
    {
        //string message = "Hello from Child";
        public new  void Greet()
        {
            Console.WriteLine(greeting ,"From child");
        }
        public void ShowMessage()
        {
            Console.WriteLine("This is Child class method");
        }
    }
    public class UpcastingDowncastingExample
    {

        // Upcasting
        public static void UpcastingDownCasting()
        {
            Child child = new Child();
            child.Greet();
            child.ShowMessage();
            Parent parent = child;
            parent.Greet();
            //down casting -> downcasting is must
            Parent p = new Child();
            ((Child)p).ShowMessage(); 






        }
    }
}
