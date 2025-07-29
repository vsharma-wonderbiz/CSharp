using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {

            bool valid = false;
            while (!valid)
            {
                try
                {
                    int num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(num);
                    valid = true;
                }catch(FormatException ex)
                {
                    Console.WriteLine("enetr a number"+ex.Message);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("enter the value in range"+ex.Message);
                }
                finally
                {
                    Console.WriteLine("excute");
                }
            }

           

            Console.ReadLine();
        }
    }
}
