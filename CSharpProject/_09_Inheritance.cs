using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    public class _09_Inheritance
    {
        public _09_Inheritance(int i)
        {
            Console.WriteLine($"the result is {i}");
        }
    }
    public class Two : _09_Inheritance
    {
        public Two() : base(10)
        {
            Console.WriteLine("this is two constructor");
        }

        public static void Main()
        {
            Two t = new Two();
        }
    }

}
