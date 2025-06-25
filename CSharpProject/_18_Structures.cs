using System;
namespace CSharpProject
{
    struct MYstruct
    {
        int i;
        public MYstruct(int i)
        {
            this.i = i;
        }
        public void display()
        {
            Console.WriteLine("this is the struct method"+i);
        }
        static void Main()
        {
            MYstruct m1=new MYstruct(); // this is a default constructor there will be for structures
            m1.display();
            MYstruct m2 = new MYstruct(30); // this is explict constructor 
            m2.display();
        }
    }
}