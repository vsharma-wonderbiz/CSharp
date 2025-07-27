using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Strings
{
    internal class Program
    {

        public static void Table(string num)
        {
            int i = 1;
            if(int.TryParse(num ,out int result))
            { 
                 while(i<=10)
                {
                    Console.WriteLine(result*i);
                    i++;
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("input is invalid");
            }
        }

        public static void FizzBuzz(int n)
        {
            int i = 0;
            while (i<n)
            {
                if(i%3==0)
                {
                    Console.WriteLine("fizzz"+i);
                    i++;
                }else if(i%5==0)
                {
                    Console.WriteLine("buzzz" + i);
                    i++;
                }
                else if(i%3==0 && i%5==0)
                {
                    Console.WriteLine("fizz-buzz");
                    i++;
                }
            }
        }

        public static void SayHello()
        {
            Console.WriteLine("hello goto");
        }
        static void Main(string[] args)
        {
            //command line arguments
            int[] arr = { 4, 5, 2, 6, 4, 5, 6, };

            for( int i = 0;i<arr.Length;i++)
            {
                if(arr[i] == 6)
                {
                    goto skip;
                }else
                {
                    Console.WriteLine(arr[i]);
                }
            }

        skip:
            SayHello();


        }
    }
}
