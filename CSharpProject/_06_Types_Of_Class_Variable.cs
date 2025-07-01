using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    internal class _06_Types_Of_Class_Variable
    {
        int x;
        static _06_Types_Of_Class_Variable()   // Static Constructor
        {
            Console.WriteLine("This is a types of class variable");
        }
        public _06_Types_Of_Class_Variable(int i) // Parametarized Constructor
        {
            this.x = i;
        }
        public void display() // Method
        {
            Console.WriteLine("the varibale is" + x);
        }
        public _06_Types_Of_Class_Variable(_06_Types_Of_Class_Variable obj) // Copy Constructor
        { 
            this.x = obj.x;
        }
        static void Main() // main method 
        {
            _06_Types_Of_Class_Variable obj1 = new _06_Types_Of_Class_Variable(10);
            obj1.display();
            _06_Types_Of_Class_Variable obj2 = new _06_Types_Of_Class_Variable(obj1); // instance reference 
            obj2.display();
            _06_Types_Of_Class_Variable obj3 = obj2; // referance Variable 
            obj3.display();
        }
    }
}
