using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StringHandeling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "hello world";
            s1 += " vinay";
            Console.WriteLine(s1);

            string s2 = "hello" + " world";
            Console.WriteLine(s2);

            string s3 = String.Concat("hello", " world", " vinay");
            Console.WriteLine(s3);

            string s6 ="hello world";

            string name = "vinay";
            int age = 30;

            StringBuilder s = new StringBuilder();
            s.Append('a');
            Console.WriteLine(s);
            string st = $"hello my name is {name} and my age is {age}";
            Console.WriteLine(st);

            Console.WriteLine(String.Compare(s1, s2));
            Console.WriteLine(s1 == s3);
            Console.WriteLine(s1 == s6);
            Console.WriteLine(s1.Equals(s3));
            Console.WriteLine("Enter the string to reverse");
            string str = Console.ReadLine().ToLower();
            string reverse = "";

            for (int i = str.Length - 1; i >= 0; i--)  // Loop backwards
            {
                reverse += str[i];
            }

            Console.WriteLine("The reverse string is " + reverse);

            Console.WriteLine("Password Checker");

            Console.WriteLine("Enter the 8 digit paswword");
            string pass = Console.ReadLine();
            Console.WriteLine("Confirm Password");
            string confirm = Console.ReadLine();

            if(pass==confirm)
            {
                Console.WriteLine("Password Match");
            }else
            {
                Console.WriteLine("Password Didnt Match");
            }

                Console.ReadLine();

        }
    }
}
