using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Passenger
    {
        
        
    }

    class Booking
    {
        public static void Book(int Noft)
        { 
            if (Noft > 2)
                throw new Exception("Cannot book more than 2 tickets");
            Console.WriteLine("Ticket Booked Successfully");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of tickets to be booked: ");
            int no_of_tickets = Convert.ToInt32(Console.ReadLine());
            try
            {
                Booking.Book(Noft);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
