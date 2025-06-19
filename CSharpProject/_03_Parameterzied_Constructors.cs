using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class _03_Parameterzied_Constructors
    {
        int x;
        public _03_Parameterzied_Constructors(int i)
        {
            x = i;
            Console.WriteLine("Parameterzied constructors is called" + i);
        }
        public void display()
        {
            Console.WriteLine("This is a method calling vlaue " + x);
        }
        static void Main()
        {
            _03_Parameterzied_Constructors obj= new _03_Parameterzied_Constructors(10);
            _03_Parameterzied_Constructors obj2 = new _03_Parameterzied_Constructors(20);
            obj.display();
            obj2.display();
            Console.ReadLine();
        }
    }
}
