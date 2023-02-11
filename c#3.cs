using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
         public static void Main(string[] args)
        {
            int f= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(f);
            int two = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(two);
            int add = f + two;
            int sub = f - two;
            int div = f / two;
            int mul = f * two;
            Console.WriteLine("the addition of two number is: "+add);
            Console.WriteLine("subration of two number is :"+sub);
            Console.WriteLine("division of two number is:"+div);
            Console.WriteLine("multipication of two number is:"+mul);
            Console.ReadLine();
        }
        

    }
}
