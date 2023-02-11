using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
     class Program
    {
        public void merit(int m,float f)
        {
            Console.WriteLine("enter your mark");

            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your fees");
            f = Convert.ToInt32(Console.ReadLine());
            if(m>=70 && m<=80)
            {
                Console.WriteLine("Scholarship amount :" + 0.2 * f);

            }
            else if(m>80 && m<=90)
            {
                Console.WriteLine("Scholarship amount :" + 0.3 * f);

            }
            else if(m>90)
            {
                Console.WriteLine("Scholarship amount :" + 0.5 * f);

            }

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.merit(91,50000);
            Console.ReadLine();


        }
    }
}
