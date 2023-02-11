using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{  interface IStudent
    {
        int StudentId { get; set; }
        string Name { get; set; }
        void ShowDetails();
    }

    
    class Dayscholar : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("Day Scholar Details");
            Console.WriteLine("Student ID: " + StudentId);
            Console.WriteLine("Name: " + Name);
        }
    }
    class Resident : IStudent
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine("Resident Details");
            Console.WriteLine("Student ID: " + StudentId);
            Console.WriteLine("Name: " + Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Dayscholar dayscholar = new Dayscholar();
            dayscholar.StudentId = 1;
            dayscholar.Name = "kalicharan";


            Resident resident = new Resident();
            resident.StudentId = 2;
            resident.Name = "kalicharan";


            Console.WriteLine("\n");
            dayscholar.ShowDetails();


            Console.WriteLine("\n");
            resident.ShowDetails();
        }
    }
}
