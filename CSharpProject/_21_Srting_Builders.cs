using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class _21_Srting_Builders
    {
        static void Main()
        {
            string s = "helo";
            Stopwatch sw1 = new Stopwatch();
            sw1.Start();
            for (int i = 1; i < 100000; i++)
            {
                s = s + i;
            }
            sw1.Stop();
            Stopwatch sw2 = new Stopwatch();
            StringBuilder s1 = new StringBuilder("hello");
            
            sw2.Start();
            for (int i = 1; i < 100000; i++)
            {
                s1.Append(i);
            }
            sw1.Stop();
            Console.WriteLine("the time take by string is " + sw1.ElapsedMilliseconds);
            Console.WriteLine("the time take by stringBuilders is " + sw2.ElapsedMilliseconds);


        }
    }
}
