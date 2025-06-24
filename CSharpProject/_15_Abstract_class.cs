using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class _15_Abstract_class
    {
        public abstract class figure
        {
            public double lenght, breadth, radius;
            public const float pi = 3.14f;
            public abstract double GetAera();
        }
        public class square : figure
        {
            public square(double lenght)
            {
                this.lenght = lenght;
            }
            public override double GetAera()
            {
                return lenght * lenght;
            }
        }
        public class circle : figure
        {
            public circle(double radius)
            {
                this.radius = radius;
            }
            public override double GetAera()
            {
                return figure.pi * radius * radius;
            }
            static void Main()
            {
                square s = new square(10);
                double res = s.GetAera();
                Console.WriteLine($"the are of the square is {res}");
                circle c = new circle(12);
                double res1 = c.GetAera();
                Console.WriteLine(res1);
            }
        }
    }
}
