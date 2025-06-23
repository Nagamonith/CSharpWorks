using System;

namespace CSharpProject
{
    public class _08_Inheritance
    {
        static _08_Inheritance()
        {
            Console.WriteLine("this is static method");
        }

        public _08_Inheritance()
        {
            Console.WriteLine("this is _08_Inheritance constructor");
        }
        static void Main()
        {
            Progra obj1 = new Progra();  // ✅ Matches the class name
        }
    }

    public class Progra : _08_Inheritance  // ✅ Changed to Program
    {
        public Progra()
        {
            Console.WriteLine("this is A constructor");
        }

        
    }
}
