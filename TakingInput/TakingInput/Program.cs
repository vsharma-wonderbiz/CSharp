using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace TakingInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //these is basically conatina how we can take input in c#
            //int a = Console.Read();
            //Console.WriteLine(a);

            //garde assigner

            int marks = Convert.ToInt32(Console.ReadLine());

            if (marks > 0 && marks < 35)
            {
                Console.WriteLine("the Grade is C" + marks);
            }
            else if (marks > 35 && marks < 70)
            {
                Console.WriteLine("the grade is B" + marks);
            }
            else
            {
                Console.WriteLine("the grade is A" + marks);
            }

            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 0 || age > 120)
            {
                Console.WriteLine("Invalid Age");
            }

            //Arrays in C#




        }

    }
}
        
