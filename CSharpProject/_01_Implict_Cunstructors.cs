using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class _01_Implict_Cunstructors
        
    {
        int i; bool b; // implict constructor which assin the default value 
        static void Main(string[] args)
        {
            _01_Implict_Cunstructors p= new _01_Implict_Cunstructors();
        
            Console.WriteLine(p.i);
            Console.WriteLine(p.b);
        }
    }
}
