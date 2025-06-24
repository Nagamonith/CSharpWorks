using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class _14_Operator_overloading
    {
        public class Matrix
        {
            private int a;
            private int b;
            private int c;
            private int d;

            public Matrix(int a, int b, int c, int d)
            {
                this.a = a;
                this.b = b;
                this.c = c;
                this.d = d;
            }

            public static Matrix operator +(Matrix obj1, Matrix obj2)
            {
                return new Matrix(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d);
            }
            public void display()
            {
                Console.WriteLine($"{a},{b},{c},{d}");
            }
        }

        static void Main()
        {
            Matrix m = new Matrix(10, 20, 30, 40);
            Matrix m1 = new Matrix(10, 20, 30, 40);
            Matrix res = m + m1;
            res.display();
            m1.display();
        }
    }
}
