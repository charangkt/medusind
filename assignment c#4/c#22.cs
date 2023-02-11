using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    
     class Program
    {
        const int Totalfar = 200;
        public string name;
        public int age;
        public void cal()
        {
            if(age<12)
            {
                Console.WriteLine("hai dude your child"+"your fare is:" + Totalfar * 0.5);
            }
            else if(age>60)
                {
                Console.WriteLine("hai sir your old " + " your fees is:" + Totalfar * 0.75);
            }
            else
            {
                Console.WriteLine(" your adult "+"your fess is :" + Totalfar);
            }
        }
        static void Main(string[] args)
        {
            Program p= new Program();
            Console.Write("Enter your name: ");
            p.name = Console.ReadLine();

            Console.Write("Enter your age: ");
            p.age = int.Parse(Console.ReadLine());
            p.cal();
            Console.ReadLine();

        }
    }
}
