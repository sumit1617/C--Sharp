using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Student
    {
        private int rno;
        private String sname;

        void Accept(int rno, String sname)
        {
            this.rno = rno;
            this.sname = sname;
        }

        void Display()
        {
            Console.WriteLine("rno is {0} and name is {1}", rno, sname);
        }

        public static void Main()
        {
            Student student1 = new Student();
            student1.Accept(18, "sumit");
            student1.Display();

            Student student2 = new Student();
            student2.Accept(45, "prajwal");
            student2.Display();
        }
    }
}
