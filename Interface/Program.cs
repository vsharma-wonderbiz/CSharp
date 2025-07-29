using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        interface Human
        {
            void Walking();
            void Speaking();
        }

        class Male : Human
        {
            public void Walking()
            {
                Console.WriteLine("hello i cam an human and i can walk");
            }
            public void Speaking()
            {
                Console.WriteLine("hello i am a male in can speak");
            }

        }
        static void Main(string[] args)
        {
            int[][] arr = new int[][]
            {
                new int[] {1,2,3,4,5},
                new int[] {2,3,4,5},
                new int[] {3,5}
            };

            Console.WriteLine("jagged arrays");//these is means arrays inside array         

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]+" ");
                }
                Console.WriteLine();
            }

            
          Male male = new Male();
            male.Walking();
            male.Speaking();


            Console.ReadLine();
        }   
    }
}
