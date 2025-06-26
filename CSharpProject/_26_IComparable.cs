using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProject
{
    class Student : IComparable<Student>
    {
        public string Name;
        public int Marks;

        public Student(string name, int marks)
        {
            Name = name;
            Marks = marks;
        }

        public int CompareTo(Student other)
        {
            // Sort by Marks in ascending order
            return this.Marks.CompareTo(other.Marks);
        }
    }
    internal class _26_IComparable
    {
        static void Main()
        {
            List<Student> list = new List<Student>();
            list.Add(new Student("Alice", 90));
            list.Add(new Student("Bob", 75));
            list.Add(new Student("Charlie", 85));

            list.Sort(); // uses CompareTo

            foreach (Student s in list)
            {
                Console.WriteLine($"{s.Name} - {s.Marks}");
            }
        }
    }
}
