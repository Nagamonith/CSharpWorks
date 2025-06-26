using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Schema;

namespace CSharpProject
{
    internal class _24_List
    {
        class customer
        {
            int id;
            string name;
            int age;
        }
        static void Main()
        {
            List<int> li = new List<int>();
            li.Add(10); li.Add(20); li.Add(30); li.Add(40); li.Add(50); li.Add(60); li.Add(70); li.Add(80);
            for (int i = 0; i < li.Count; i++)
            {
                Console.WriteLine(li[i]);
            }
            List<customer> C = new List<customer>();
            foreach (object obj in C)
            {
                Console.WriteLine(obj);
            }
            
        }
    }
}
