using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public enum days
    {
        Monday=1,Tuesday,Wednesday,Thursday,Friday
    }
    internal class _19_Enum
    {
        public days MeetingDay
        {
            get; set;
        } = days.Monday;
        static void Main()
        {
            foreach(string i in Enum.GetNames(typeof(days)))
            {
                Console.WriteLine(i);
            }

        }

    }
}
