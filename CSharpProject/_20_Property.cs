using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class _20_Property
    {
        public class Circle
        {
            double _Radius = 12.2;
            public double Radius
            {
                get { return _Radius; }
                set {
                    if (value > _Radius) { _Radius = value; } }
            }
        }
        static void Main()
        {
            Circle c = new Circle();
            double radius=c.Radius;
            Console.WriteLine(radius);
            c.Radius = 11;
            Console.WriteLine(c.Radius);
            
        }
    }
}
