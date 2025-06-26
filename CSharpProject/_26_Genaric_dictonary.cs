using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class _26_Genaric_dictonary
    {
        class customer
        {
            public int _Cid { get; set; }
            public string _Cname { get; set; }
            public bool _Status { get; set; }
            public double _Balance { get; set; }

            // Constructor to initialize properties  
            public customer(int cid, string cname, bool status, double balance)
            {
                _Cid = cid;
                _Cname = cname;
                _Status = status;
                _Balance = balance;
            }
        }

        static void Main()
        {
            Dictionary<string, object> dt = new Dictionary<string, object>();
            dt.Add("name", "monith");
            dt.Add("age", 20);
            dt.Add("marks", 95);
            foreach (KeyValuePair<string, object> kvp in dt)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            customer c1 = new customer(1, "John Doe", true, 1000.50);
            List<customer> customers = new List<customer>();
            customers.Add(c1);   
            foreach (customer cust in customers)
            {
                Console.WriteLine($"Customer ID: {cust._Cid}");
            }
        }
    }
}
