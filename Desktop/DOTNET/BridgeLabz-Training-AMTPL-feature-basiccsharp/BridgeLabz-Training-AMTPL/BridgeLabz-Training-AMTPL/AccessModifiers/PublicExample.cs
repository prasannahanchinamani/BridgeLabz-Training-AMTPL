using System;

namespace BridgeLabz_Training_AMTPL.AccessModifiers
{
    public class PublicExample
    {
        public int publicField = 1;
        private int privateField = 2;
        protected int protectedField = 3;
        internal int internalField = 4;
        protected internal int protectedInternalField = 5;
        private protected int privateProtectedField = 6;

        public void ShowValues()
        {
            Console.WriteLine("Inside PublicExample:");
            Console.WriteLine($"publicField = {publicField}");
            Console.WriteLine($"privateField = {privateField}");
            Console.WriteLine($"protectedField = {protectedField}");
            Console.WriteLine($"internalField = {internalField}");
            Console.WriteLine($"protectedInternalField = {protectedInternalField}");
            Console.WriteLine($"privateProtectedField = {privateProtectedField}");
        }
    }

    internal class InternalExample : PublicExample
    {
        public void ShowInheritedValues()
        {
            Console.WriteLine("Inside InternalExample:");
            Console.WriteLine($"publicField = {publicField}");
            Console.WriteLine($"protectedField = {protectedField}");
            Console.WriteLine($"internalField = {internalField}");
            Console.WriteLine($"protectedInternalField = {protectedInternalField}");
            Console.WriteLine($"privateProtectedField = {privateProtectedField}");
        }
    }

    public class TestAccess
    {
        public void Run()
        {
            PublicExample pub = new PublicExample();
            Console.WriteLine("Inside TestAccess:");
            Console.WriteLine($"publicField = {pub.publicField}");
            Console.WriteLine($"internalField = {pub.internalField}");
            Console.WriteLine($"protectedInternalField = {pub.protectedInternalField}");
        }
    }

   
}