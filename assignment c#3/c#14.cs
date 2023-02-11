using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        public int salesno, qty, price;
        public double productno, totalamount;
        public string datasale;
        public Program(int salesno, double productno, int qty, string datasale)
        {
            this.salesno = salesno;
            this.productno = productno;
            this.qty = qty;
            this.datasale = datasale;
        }
        public void sales (int qty, int price)
            {
            totalamount= price;
            Console.WriteLine("enter the total amount");
            Console.WriteLine(totalamount);
            }
        static void Main(string[] args)
        {
            Program p = new Program(55,100.2,500,"17/10/2023");
            p.sales(5, 500);
            Console.ReadLine(); 

        }
    }
}
