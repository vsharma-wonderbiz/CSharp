using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();//these is a class  stored in heap
            list.Add(1);//so here the 1 is ingt value type store in heap it is undetsood as obj;//here the in is boxed in obj and stored as arrylist 
            Console.WriteLine(list.GetType());
            //int num2 = list[0];//these will give error
            int num = (int)list[0];//here the obj is bascially converted to value type 
            Console.WriteLine(num.GetType());

            //in mordern days generics are use 
            List<int> number = new List<int>();
            number.Add(1);
            int value = number[0];
            Console.WriteLine(value);


            int ? x=null;//nullabe types
            Console.ReadLine();

            const int y=10;

            readonly int z;
        }
    }
}
