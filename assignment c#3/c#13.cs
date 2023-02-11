using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
     class Program
    {
        private double regno;
        private string name;
        private int feescharged;
        public double Regno
        {
            get
            {
                return regno;
            }
            set
            {
                regno = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }   
        }
        public int Feescharged
        {
                get { return feescharged; }
            set {feescharged= value; }
        }
     
       public static void Main(string[] args)
        {
            Program p=new Program();
            p.regno = 2222.0;
            p.name = "charan";
            p.feescharged = 50000;
            Console.WriteLine("your name is: "+p.name);
            Console.WriteLine("your reg number is:"+p.regno);
            Console.WriteLine("your fees is :"+p.feescharged);
            Console.ReadLine();



        }
    }
}
