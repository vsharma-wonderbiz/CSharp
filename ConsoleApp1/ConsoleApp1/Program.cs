using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        static Boolean IsPalindrome(int n)
        {
            int lastdigit = 0;
            int reverse = 0;
            int number = n;
            while(n>0)
            {
                lastdigit = n % 10;
                reverse = reverse * 10 + lastdigit;
                n = n / 10; 
            }

            if(number==reverse)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("the numric data types");
            int age = 23;
            string convertStr = Convert.ToString(age);//to convert to string 
            Console.WriteLine(convertStr);
            Console.WriteLine("the type is "+convertStr.GetType());
            long num = 4000000000L;

            double dec = 456.565656D;
            float dec2 =454.545454f;

            Console.WriteLine(age);
            Console.WriteLine(num);
            Console.WriteLine(dec);
            Console.WriteLine(dec2);
            Console.WriteLine(dec);


            //text based datatypes 
            string str = "vinay";
            char ch = 'a';
            
            Console.WriteLine("your name is=" + str);
            Console.WriteLine(ch);

            //Type Casting string to number
            string str2 = "-24";
            int convert = Convert.ToInt32(str2);//to convert string ot int 32 bit 
            Console.WriteLine(convert);
            string toBigNumber = "40000000000";
            long convert2 = Convert.ToInt64(toBigNumber);//to convert to a long value 64 bit 
            Console.WriteLine(convert2);
            string decString = "3456.565676";
            double convert3 = Convert.ToDouble(decString);//to convert to doublr of the string 
            Console.WriteLine(convert3);


            Console.WriteLine("these is are the operators oprators");


            int a = 45;
            int b = 45;

            a = a + 1;
            a++;
            a = +1;
            Console.WriteLine(a+b);
            Console.WriteLine(a-b);
            int c = 2;
            int d = 5;
            Console.WriteLine(c*d);

            if(IsPalindrome(123))
            {
                Console.WriteLine("yes Palindrome");
            }
            else
            {
                Console.WriteLine("no not a plaindrome");
            }
            

            


        }
    }
}
