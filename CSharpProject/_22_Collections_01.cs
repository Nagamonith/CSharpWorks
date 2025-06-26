using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class _22_Collections_01
    {
        static void Main()
        {
            ArrayList ar = new ArrayList();
            ar.Add(100);
            ar.Add(200);
            ar.Add(300);
            
            ar.Add(400);
            ar.Add(500);
            foreach (object obj in ar)
            {
                Console.WriteLine(obj + " ");
            }
            Console.WriteLine(ar.Capacity);
            ar.Insert(0, 50);
            foreach (object obj in ar)
            {
                Console.WriteLine(obj + " ");
            }
            ar.Remove(50);
            foreach (object obj in ar)
            {
                Console.WriteLine(obj + " ");
            }

        }
    }
}
