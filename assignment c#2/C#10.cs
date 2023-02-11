using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
     class Program
    {
        public string name, branch, class1;
        public int sem;
        public long rollno;
        public int[] marks = new int[5];
        Program(long rollno, string name, string class1, int sem, string branch, int[] marks)
        {
            this.rollno = rollno;
            this.name = name;
            this.class1 = class1;
            this.sem = sem;
            this.branch = branch;
            this.marks = marks;
        }
        int GetMarks()
        {
            Console.Write("The marks are: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(marks[i] + " ");
            }
            return 0;
        }
        int displayresult()
        {
            float avg = 0;
            for (int i = 0; i < 5; i++)
            {
                avg = avg + marks[i];
            }
            avg = avg / 5;
            Console.WriteLine();
            Console.Write("The avg marks are: " + avg);
            int flag = 0;
            for (int i = 0; i < 5; i++)
            {
                if (marks[i] < 35)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1 || avg < 50)
            {
                Console.WriteLine("The result is Fail");
            }
            return 0;
        }
        int DisplayData()
        {
            Console.WriteLine();
            Console.WriteLine("Student detail are:");
            Console.WriteLine(rollno + " " + name + " " + class1 + " " + sem + " " + branch);
            return 0;
        }


        static void Main(string[] args)
        {
            int[] arr = { 99, 98, 97, 96, 100 };
            Program obj = new Program (1, "charan", "Btech", 4, "IT", arr);
            Console.WriteLine("*****************STUDENT DETAILS **************");
            obj.GetMarks();
            obj.displayresult();
            obj.DisplayData();
        }
    }
}
