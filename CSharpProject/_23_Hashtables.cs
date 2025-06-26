using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class _23_Hashtables
    {
        static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("Name", "Monith");
            ht.Add("age",20);
            ht.Add("job","developer");
            ht.Add("salary",30000);
            ht.Add("location","jayanagar");
            foreach (object key in ht.Keys)
            {
                Console.WriteLine(key + ":" + ht[key]);
            }
        }
    }
}
