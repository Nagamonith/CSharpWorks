using System;

namespace CSharpProject
{
    interface IOperation
    {
        void add(int a, int b);
        void sub(int a, int b);
    }

    public class TestInterface : IOperation
    {
        // Explicit implementation for 'add'
        void IOperation.add(int a, int b)
        {
            Console.WriteLine($"The addition is {a + b}");
        }

        // Implicit implementation for 'sub'
        public void sub(int a, int b)
        {
            Console.WriteLine($"The subtraction is {a - b}");
        }

        // ✅ Main method inside the public class
        public static void Main()
        {
            IOperation obj = new TestInterface();
            obj.add(10, 20);
            obj.sub(10, 20);
        }
    }
}
