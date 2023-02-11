using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
     class Program
    {
        
       public int employeeid;
         public  string firstname, lastname, title, city;
         public DateTime dob, doj;


        public static void Main(string[] args)
        {
            List<Program> studentlist = new List<Program>()
            {
                new Program(){employeeid=1001, firstname=" Malcolm ",lastname="Daruwalla",title="Manager ",dob=new DateTime(16/11/1984) ,doj=new DateTime(8/6/2011) ,city=" Mumbai"},
                new Program(){employeeid=1002, firstname="Asdin",lastname=" Dhalla ",title="AsstManager",dob=new DateTime(20/08/1984) ,doj= new DateTime(7/7/2012) ,city=" Mumbai"},
                new Program(){employeeid=1003, firstname="Madhavi ",lastname="  Oza ",title="  Consultant ",dob=new DateTime(14/11/1987),doj=new DateTime(12/4/2015) ,city="Pune "},
                new Program(){employeeid=1004, firstname="Saba ",lastname="Shaikh",title="SE ",dob=new DateTime(3/6/1990),doj=new DateTime(2/2/2016),city="Pune "},
                new Program(){employeeid=1005, firstname="Nazia ",lastname="Shaikh",title="SE ",dob=new DateTime(8/3/1991),doj=new DateTime(2/2/2016),city=" Mumbai"},
                new Program(){employeeid=1006, firstname="Amit ",lastname="Pathak ",title="Consultant ",dob=new DateTime(7/11/1989),doj=new DateTime(8/8/2014) ,city="Chennai "},
                new Program(){employeeid=1007, firstname="Vijay",lastname="Natrajan",title="Consultant ",dob=new DateTime(2/12/1989),doj=new DateTime(1/6/2015) ,city="Mumbai "},
                new Program(){employeeid=1008, firstname="Rahul ",lastname="Dubey",title="Associate",dob=new DateTime(11/11/1993),doj=new DateTime(6/11/2014),city="Chennai "},
                new Program(){employeeid=1009, firstname="Suresh",lastname="Mistry",title="Associate",dob=new DateTime(12/8/1992),doj=new DateTime(3/12/2014),city="Chennai "},
                new Program(){employeeid=1010, firstname="Sumit",lastname="Shah ",title="Manager ",dob=new DateTime(12/4/1991),doj=new DateTime(2/1/2016) ,city=" Pune"}

            };

            var one = from e in studentlist select e;
            foreach(var emp in one)
            {
                Console.WriteLine(emp.employeeid +" "+emp.firstname+" "+emp.lastname+" "+emp.title+ " "+emp.doj.ToShortDateString()+" "+emp.dob.ToShortDateString()+" "+emp.city);
            }
            Console.WriteLine("-----------------------------------");
            var two = from emp in studentlist 
                      where emp.city !="Mumbai"
                      select emp;
            foreach (var emp in two)
            {
                Console.WriteLine(emp.city);
            }
            Console.WriteLine("-----------------------------------");
            var three = from emp in studentlist where emp.title == "AsstManager"
                        select emp;
            foreach (var emp in three)
            {
                Console.WriteLine(emp.employeeid +" "+emp.firstname+" "+emp.lastname);
            }
            Console.WriteLine("-----------------------------------");

            var four = from emp in studentlist
                       where emp.lastname.StartsWith("S")
                       select emp;  
            foreach(var emp in four)
            {
                Console.WriteLine(emp.firstname + "  " + emp.lastname);
            }
            Console.WriteLine("-----------------------------------");
            var five = from emp in studentlist
                       where emp.doj<new DateTime(2015,1,1)
                       select emp;
            foreach (var emp in five)
            {
                Console.WriteLine(emp.firstname+" "+emp.lastname+" "+emp.city);
            }

            Console.WriteLine("-----------------------------------");
            var six = (from emp in studentlist
                      select emp).Count();
            Console.WriteLine(six);
            Console.WriteLine("-----------------------------------");
            var seven = (from emp in studentlist
                         where emp.city == "Chennai"
                         select emp).Count();
            Console.WriteLine(seven);
            var nine= studentlist.Max(e => e.employeeid);
            Console.WriteLine(nine);
            Console.WriteLine("-----------------------------------");
            var ten = studentlist.Count(e => e.title != "Associate");
            Console.WriteLine(ten);
            var result = studentlist.GroupBy(e => e.city)
                .Select(group => new { city = group.Key, Count = group.Count() });
            foreach(var g in result)
            {
                Console.WriteLine(g.city + " " + g.Count);
            }
            Console.ReadLine();

            
        } 
    }
}
