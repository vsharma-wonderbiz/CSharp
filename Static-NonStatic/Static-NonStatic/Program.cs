using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Static_NonStatic
{
    public class ExampleStatic
    {
        public static int count=0;
         
        public static void Sayhello()
        {
            Console.WriteLine("hello World");
        }

        public void NonStatic()
        {
            Console.WriteLine("hey bro i am non Static");
        }
    }


    public class ExampleNonStatic
    {
        public int number;

        public void PrintName(string name)
        {
            Console.WriteLine($"hello my name is {name}");
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine(ExampleStatic.count);
            ExampleStatic.Sayhello();

            Console.WriteLine();
            Console.WriteLine("hello i ma the nin static function");
            ExampleNonStatic e = new ExampleNonStatic();
            e.number = 10;
            Console.WriteLine(e.number);
            e.PrintName("vinay");
           
        }
    }
}
