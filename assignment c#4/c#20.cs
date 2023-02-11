using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program1
    {
        private const int TotalFare = 500;
        public static void cal(int age)
        {
            if (age <= 5)
            {
                Console.WriteLine("free ticket for childrens");
            }
            else if (age > 60)
            {
                int discount = (int)(TotalFare * 0.3);
                int finalfare = TotalFare - discount;
                Console.WriteLine("SENIOR CITIZEN:" + finalfare);
            }
            else
            {
                Console.WriteLine("adult fare is :" + TotalFare);
            }
        }
    }
        class Program
        { 
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int age=Convert.ToInt32(Console.ReadLine());
            Program1.cal(age);
            
            Console.ReadLine();
        }
    }
}
