using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class _05_Static_Constructors
    {
        
        static _05_Static_Constructors()
        {
            Console.WriteLine("The static method is excuted");
        }
        static void Main()
        {
            Console.WriteLine("The main method is executed");
        }
    }
}
