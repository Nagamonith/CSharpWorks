using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Employee
    {
        int eid;
        string ename, job, location;
        double salary;

        public Employee(int eid, string name, string job, string location, double salary)
        {
            this.eid = eid;
            this.ename = name;
            this.job = job;
            this.location = location;
            this.salary = salary;
        }

         
        public object this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return eid;
                    case 1:
                        return ename;
                    case 2:
                        return job;
                    case 3:
                        return location;
                    case 4:
                        return salary;
                    default:
                        return null;
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        eid =(int)(value);
                        break;
                    case 1:
                        ename =(string)(value);
                        break;
                    case 2:
                        job = (string)(value);
                        break;
                    case 3:
                        location = (string)(value);
                        break;
                    case 4:
                        salary = (double)(value);
                        break;
                    default:
                        throw new IndexOutOfRangeException("Invalid index");
                }
            }
        }
    }
    internal class _20_Indexercs
    {
        static void Main()
        {
            Employee e = new Employee(101, "monith", "developer", "bengaluru", 20000);

             
            Console.WriteLine(e[1]);   
            e[1] = "new name";
            Console.WriteLine(e[1]); 
        }
    }
}
