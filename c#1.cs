using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace charan2
{
    internal class Program
    {
       public  static void Main(string[] args)
        {
           
            Console.WriteLine("entert the values");

            Program p = new Program();
            p.equalor();
            
            Console.ReadLine();
        }
        public void equalor()
        {
            int x = Console.Read();
            int y = Console.Read();

            if (x == y)
            {
                Console.WriteLine($"{x} is equal {y}");

            }
            else
            {
                Console.WriteLine($"{x} is not equal to {y}");
            }
            Console.ReadLine();
        }
    }
}
