using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class _02_Explict_Constructors
    {
        public _02_Explict_Constructors() {
            Console.WriteLine("Constructor is called");
        }
        static void Main() { 
            _02_Explict_Constructors obj= new _02_Explict_Constructors();
            _02_Explict_Constructors obj1 = new _02_Explict_Constructors();
            _02_Explict_Constructors obj2 = new _02_Explict_Constructors();
            Console.ReadLine();

        }

    }
} 
