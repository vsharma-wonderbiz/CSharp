using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsInCsharp
{
     class Animal
    {
        public  string name;
        private int age;

        public int Age { get; set; }
        

         void Sound(string name,string sound)
        {
            Console.WriteLine($"hello i am {name} and my soudn is {sound}");
        }

        public void CallSound(string setname,string setsound)
        {
            Sound(name:setname,sound:setsound); 
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //Animal dog = new Animal();
            //dog.name = "brunno";
            //dog.Age = 34;
            DateTime n = new DateTime(2025,7,29);//we can pass date time and year in these 
            Console.WriteLine(n);
            //Console.WriteLine(dog.Age);

            //dog.CallSound("dog", "bark");
            Vinay.hello();

            MumbaiUniversity.Ltce college = new MumbaiUniversity.Ltce();
            college.id = "hello";
            Console.WriteLine(college.id);

            college.DisplayAddress();

            Console.ReadLine();
        }
    }
}

namespace MumbaiUniversity
{
    class Ltce
    {
        public string id;

        void Addresss ()
        {
            Console.Write("kopar khairane");
        }

        public void DisplayAddress()
        {
            Addresss();
        }
    }
    class KC
    {
        
    }
}

class Vinay
{
    public static void hello()
    {
        Console.WriteLine("hello");
    }
}
