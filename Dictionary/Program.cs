using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {

       static void add(int n,string values, Dictionary<int, List<string>> set2)
        {
            if (!set2.ContainsKey(n))
            {
                set2[n] = new List<string>();
            }

            set2[n].Add(values);
        }
        static void Main(string[] args)
        {
            //dictionary are basically data strutrie that helpus store key value pairs in c# same as hashmap in java
            Dictionary<int, string> set = new Dictionary<int, string>();
            Dictionary<int, List<string>> set2 = new Dictionary<int, List<string>>();//these way can store multiple vlaue 
            SortedSet<int> set3 = new SortedSet<int>();//these is top store in sorted order 
            HashSet<string> set4 = new HashSet<string>();//these is to store unique values



            add(1, "Vinay",set2);
            add(1, "nilesh", set2);

            

            set.Add(1, "vinay");
            set.Add(3, "nilesh");
            set.Add(4, "sachin");
            Console.WriteLine(string.Join(",",set.Values));
            foreach(var n in set2)
            {
                if (n.Key== 1)
                {
                    Console.WriteLine(string.Join(",", n.Value));
                }
            }

            set3.Add(4);
            set3.Add(6);
            set3.Add(1);

            Console.WriteLine("these will coatien the elemnst in sorted order ");
            foreach(int n in set3)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("these is about hashset");
            set4.Add("vinay");
            set4.Add("vinay");
            set4.Add("Nilesh");
            set4.Add("sachin");

            foreach(var v in set4)
            {
                Console.WriteLine(v);
            }

            string name = "John";
            int age = 25;
            int ID = 4;

            string result = string.Format("Name: {0}, Age: {1} , ID: {2}", name, age,ID);
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
