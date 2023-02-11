using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public abstract class Student
    {
        public string Name ;
        public int StudentId;
        public int Grade;
        public abstract bool IsPassed(int grade);
    }

    public class Under_Graduate : Student
    {
        public override bool IsPassed(int grade)
        {
            return grade > 72.6;
        }
    }

    public class Graduate : Student
    {
        public override bool IsPassed(int grade)
        {
            return grade > 85.2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Under_Graduate UG = new Under_Graduate()
            {
                Name = "kali",
                StudentId = 9865,
                Grade = 90
            };

            Graduate GT = new Graduate()
            {
                Name = "charan",
                StudentId = 9999,
                Grade = 95
            };

            Console.WriteLine($"Undergraduate grade {UG.IsPassed(UG.Grade)}");
            Console.WriteLine($"Graduate grade {GT.IsPassed(GT.Grade)}");
        }
    }
}
