using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpProject
{
    internal class _10_Inheritance
    {
        public class Person
        {
            int _id;
            string _name;
            string _address;
            long _phone;
            public  Person(int id, string name, string address, long phone)
            {
                this._id = id;
                this._name = name;
                this._address = address;
                this._phone = phone;

            }
        }
        public class Student : Person
        {
            int _std;
            double _marks;
            string _grade;
            double _fees;
            public Student(int id, string name, string address, long phone,int std, double marks, string grade, double fees) : base(id, name, address, phone)
            {
                this._std = std;
                this._marks = marks;
                this._grade = grade;
                this._fees = fees;

            }
        }
         public class Teacher : Person
            {
                int _age;
                string _Qalification;
                string _salary;
                double _Exprience;
                public Teacher(int id, string name, string address, long phone,int age, string Qalification, string salary, double exprience) : base(id, name, address, phone)
                {
                    this._age = age;
                    this._Qalification = Qalification;
                    this._salary = salary;
                    this._Exprience = exprience;

                }



            }
          public static void Main()
        {
            Student s1 = new Student(1, "monith", "laggere", 7676119447, 7, 45, "a", 1500);
           
        }
        }

}
