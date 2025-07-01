using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class _04_Copy_Constructors
    {
        int x;
        public _04_Copy_Constructors(int i)
        {
            this.x = i;

        }
        public _04_Copy_Constructors(_04_Copy_Constructors obj)
        {
            this.x=obj.x;
        }
        public void Display()
        {
            Console.WriteLine("this is a copy method constructor" + x);
        }
        static void Main()
        {
            _04_Copy_Constructors cd= new _04_Copy_Constructors(10);
            cd.Display();   
            _04_Copy_Constructors cd2= new _04_Copy_Constructors(cd);
            cd2.Display();
            _04_Copy_Constructors cd3 = new _04_Copy_Constructors(cd);
            cd3.Display();
            _04_Copy_Constructors cd4= new _04_Copy_Constructors(cd); cd4.Display();
            _04_Copy_Constructors cd5 = new _04_Copy_Constructors(cd);
            cd5.Display();

        }
    }
}
