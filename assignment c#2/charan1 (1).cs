using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        public void len()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("enter the total number in a arary is :" + arr.Length);
        }
        public void reve()
        {
            string val = "charan";
            string reval = "null";
            for(int i=val.Length-1;i<=0;i--)
            {
                reval += val[i];
                Console.WriteLine(reval);
            }
            Console.WriteLine(val);
            
        }
        public void palidrome()
        {
            string val = "charan";
            string reval = "null";
            for (int i = val.Length - 1; i <= 0; i--)
            {
                reval += val[i];
                Console.WriteLine(reval);
            }
            if(reval==val)
            {
                Console.WriteLine("the given string is same");
            }
            else
            {
                Console.WriteLine("the given string is not same");
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.len();
            p.reve();
            p.palidrome();
      
            Console.ReadLine();

        }
    }
}
