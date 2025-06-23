using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    public class _07_Access_Specifiers
    {
        private void test1()
        {
            Console.WriteLine("this method is private");
        }
        internal void test2()
        {
            Console.WriteLine("this method is internal");
        }
        protected void test3()
        {
            Console.WriteLine("this method is protected");
        }
        protected void test4()
        {
            Console.WriteLine("this method is protected internal ");
        }
        public void test5()
        {
            Console.WriteLine("this method is public");
        }
        public static void Main()
        {
            Console.WriteLine("this is main method");
            _07_Access_Specifiers a = new _07_Access_Specifiers();
            a.test1();
            a.test2(); a.test3(); a.test4(); a.test5();
        }
    }
}
