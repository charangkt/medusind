using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
     class Program
    {
        public void str(string firstname, string secondname)
        {
            Console.WriteLine("enter your first name");
            firstname =Console.ReadLine();
            secondname = Console.ReadLine();
            firstname = firstname.ToLower();
            secondname = secondname.ToUpper();
            Console.WriteLine(firstname);
            Console.WriteLine(secondname);
        }
        static void Main(string[] args)
        {
         Program p=new Program();
            p.str("charan","bharathi");
            Console.ReadLine();


        }
    }
}
