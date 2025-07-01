using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking
{
    public class customers
    {
        public static string _CustomerName;
        private double _age;

        public customers(string name, double age)
        {
            _CustomerName = name; 
            this._age = age;
        }
    }
}