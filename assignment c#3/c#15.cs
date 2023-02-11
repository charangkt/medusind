using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
     class Program
    {
        public void counstr()
        {
            int count = 0;
            Console.WriteLine("enter your string");
            string name =Console.ReadLine();
            Console.WriteLine("enter your character");
            char ch=Convert.ToChar(Console.ReadLine());

            for(int i = 0;i<name.Length;i++)
            {
                if (name[i] == ch)
                {
                    count++;
                }
                
            }
            Console.WriteLine("count of your char is :"+count);
            Console.WriteLine(name);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.counstr();
        }
    }
}
