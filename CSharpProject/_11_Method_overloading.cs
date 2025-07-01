using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class _11_Method_overloading
    {
        public void method1()
        {
            Console.WriteLine("no arguments");
        }
        public void method2(int i)
        {
            Console.WriteLine($"this has one argument");
        }
        public void method3(string s)
        {
            Console.WriteLine("this s one argument but the type is diffrent");
        }
        public void method4(int i, string s) 
        {
            Console.WriteLine("this has 2 argument ");
            Console.WriteLine("");
            } 
        public void method5(string s , int i)
        {
            Console.WriteLine("this has 2 argument but the position is changes");
        }
        public static void Main()
        {
            _11_Method_overloading m = new _11_Method_overloading();
            m.method1();
            m.method2(1);
            m.method3("monith");
            m.method4(500,"monith");


        }


    }
}
