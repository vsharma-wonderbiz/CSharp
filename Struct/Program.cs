using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    internal class Program
    {
        

        enum Direction//named constandt in c#

        {
            East=2,
            West,
            North,
            South
        }
        struct Student
        {
            public int rollno;
            public string name;

            public Student(int rollno,string name)
            {
                this.rollno = rollno;
                this.name = name;
            } 
        }
        static void Main(string[] args)
        {
            Student s = new Student();
            s.rollno = 21;
            s.name = "vinay";
            Console.WriteLine(s.rollno);
            Console.WriteLine(s.name);
            Student[] s1 = new Student[3];

            s1[0] = new Student(1, "nilesh");
            s1[1] = new Student(2, "vinay");
            s1[2] = new Student(3, "scahin");

            var employee = new { id = 1, name = "vinay", surname = "sharma" };
            Console.WriteLine(employee.id);
            //employee.name = "nilesh";//not allowed 

            Console.WriteLine(s1[0].rollno);

            Direction s2 = Direction.South;
            Console.WriteLine((int)s2);


            Console.ReadLine();
        }
    }
}
