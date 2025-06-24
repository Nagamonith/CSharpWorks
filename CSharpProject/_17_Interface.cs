using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    interface _17_Interface
    {
        void test1();
        void display();
    }
    interface test2
    {
        void test1();
        void display();
    }
    public class _17_interface : _17_Interface, test2
    {
        public void test1()
        {
            Console.WriteLine("this is a interface class");
        }
        void _17_Interface.display()
        {
            Console.WriteLine("this is main interface");
        }
        void test2.display()
        {
            Console.WriteLine("this is 2nd interface");
        }
        static void Main()
        {
            // Fix: Create an instance of the implementing class instead of the interface  
            _17_Interface obj = new _17_interface();
            obj.test1();
        }
    }
}
