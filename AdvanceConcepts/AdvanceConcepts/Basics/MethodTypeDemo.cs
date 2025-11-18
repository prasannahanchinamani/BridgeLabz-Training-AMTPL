using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceConcepts.Basics
{
    abstract class Shape
    {
        public abstract void Draw();
    }


    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Circle");
        }
    }

    class Demo
    {
        public int number;
        public static int staticNumber;

        // 1. STATIC CONSTRUCTOR
        static Demo()
        {
            staticNumber = 100;
        }

        //2. DEFAULT CONSTRUCTOR 
        public Demo()
        {
            number = 10;
        }

        // 3. INSTANCE METHOD 
        public void ShowInstance()
        {
            Console.WriteLine("Instance Method");
        }

        //  4. STATIC METHOD 
        public static void ShowStatic()
        {
            Console.WriteLine("Static Method");
        }

        //  5. METHOD WITH PARAMETER
        public void PrintNumber(int x)
        {
            Console.WriteLine("Number = " + x);
        }

        //  6. METHOD WITH RETURN TYPE 
        public int Add(int a, int b)
        {
            return a + b;
        }

        //  7. VOID METHOD 
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        // 8. REF PARAMETER METHOD 
        public void Increment(ref int value)
        {
            value++;
        }

        //  9. OUT PARAMETER METHOD 
        public void GetValues(out int x, out int y)
        {
            x = 10;
            y = 20;
        }

        // 10. METHOD OVERLOADING
        public void Multiply(int a, int b)
        {
            Console.WriteLine("Multiply = " + (a * b));
        }

        public void Multiply(double a, double b)
        {
            Console.WriteLine("Multiply Double = " + (a * b));
        }



        // 12. PRIVATE METHOD 
        private void SecretMethod()
        {
            Console.WriteLine("Private Method");
        }

        //13. protected METHOD 
        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected Method");
        }

        // ---------- 14. PROPERTY METHODS (GETTER & SETTER) ----------
        private int age;
        public int Age
        {
            get { return age; }      // getter method
            set { age = value; }     // setter method

        }
    }

    public class MethodTypeDemo
    {
        public static void run()
        {
            Demo obj = new Demo();

            // Instance method
            obj.ShowInstance();

            // Static method
            Demo.ShowStatic();

            // Parameterized + return type
            Console.WriteLine("Add = " + obj.Add(5, 7));

            // Void method
            obj.SayHello();

            // ref method
            int val = 5;
            obj.Increment(ref val);
            Console.WriteLine("Ref Value = " + val);

            // out method
            obj.GetValues(out int x, out int y);
            Console.WriteLine($"Out Values: x={x}, y={y}");

            // Method Overloading
            obj.Multiply(3, 4);
            obj.Multiply(3.5, 2.5);

            // Property methods
            obj.Age = 25;
            Console.WriteLine("Age = " + obj.Age);

            // Abstract + override method
            Shape shape = new Circle();
            shape.Draw();
        }
    }


}