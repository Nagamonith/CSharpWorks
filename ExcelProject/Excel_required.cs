using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelProject
{
    internal class Excel_required
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            long num = long.Parse(Console.ReadLine());


            string result = "";

            while (num > 0)
            {
                num--; 
                result = (char)('A' + num % 26) + result;
                num /= 26;
            }

            Console.WriteLine("Excel Column: " + result);
        }
    }
}
