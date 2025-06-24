using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class _13_Method_hiding
    {

        public class Parent
        {
            public virtual void Test1()
            {
                Console.WriteLine("this is a parent calss test 1");
            }
            public void Test2()
            {
                Console.WriteLine("this is a parent class test 2");
            }
        }
        public class Child : Parent
        {
            public override void Test1()
            {
                Console.WriteLine("this is a child calss test 1");
            }
            public new void Test2()
            {
                Console.WriteLine("this is a child calss test 2");
            }
            public void ParentTest1()
            {
                base.Test1();
            }
            public void ParentTest2()
            {
                base.Test2();
            }
        }
        
        static void Main()
        {
            Child c = new Child();
            c.Test1();
            c.Test2();
            c.ParentTest1();
            c.ParentTest2();

        }
    }
}
