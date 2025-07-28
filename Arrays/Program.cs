using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("enter the size of the error");
            //int n=Convert.ToInt32(Console.ReadLine());

            //int[] arr = new int[n];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"enter the value at{i + 1} position");
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write(arr[i] + " ");
            //}

            //foreach (int num in arr)
            //{
            //    Console.Write(num + " ");
            //}
            int[] arr = { 3, 5, 4, 6, 7, };
            int[] numbers = new int[]
            {
                4, 5, 5
            };

            int[] newarr = new int[arr.Length];
            Array.Copy(arr,newarr,newarr.Length);

            foreach (int n1 in newarr)
            {
                Console.WriteLine(n1);
            }

            int num = Array.IndexOf(arr, 4);
            Console.WriteLine("these is the index of function"+num);

            //to dimensional array
            int[,] matrix = { { 1, 2, 3 }, { 3, 4, 5 } };

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]+"-");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
