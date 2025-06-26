using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class trygenarics
    {
        public void addtion<T>(T a, T b)
        {
              
            dynamic dynamicA = a;
            dynamic dynamicB = b;

             
            dynamic result = dynamicA + dynamicB;
            Console.WriteLine(result);
        }
        public void check<T>(T a,T b)
        {
            if (a.Equals(b))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
    internal class _25_Genarics
    {
        static void Main()
        {
            trygenarics t = new trygenarics();
            t.check<int>(10, 20);
            t.addtion(10, 20);
        }
    }
}
