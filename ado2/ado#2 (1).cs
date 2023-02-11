using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ado.NetAssignment
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand Cmd;

        static void Main(string[] args)
        {
            Insert_values();
            Console.Read();
        }
        static SqlConnection GetConnection()
        {
            con = new SqlConnection("Data Source=LAPTOP-RNFDJ0QL\\SQLEXPRESS;Initial Catalog=charan;" +
                "Integrated Security=true;");
            con.Open();
            return con;
        }


        static void Insert_values()
        {
            con = GetConnection();


            Console.WriteLine("Enter Employee Details :");
            Console.WriteLine("Employee Number:");
            int Empno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Employee Name");
            string EmpName = Console.ReadLine();

            Console.WriteLine("Employee Salary:");
            double EmpSal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Employee Type:");
            Char EmpType = Convert.ToChar(Console.ReadLine());

            Cmd = new SqlCommand("INSERT INTO Code_Employee VALUES(@empno, @empname, @empsal, @emptype)");

            Cmd.Parameters.AddWithValue("@empno", Empno);
            Cmd.Parameters.AddWithValue("@empname", EmpName);
            Cmd.Parameters.AddWithValue("@empsal", EmpSal);
            Cmd.Parameters.AddWithValue("@emptype", EmpType);
            Cmd.Connection = con;

            int values = Cmd.ExecuteNonQuery();
            if (values > 0)
            {
                Console.WriteLine("Employee Details Stored SuccessFully");
            }
            else
            {
                Console.WriteLine("An Error Occured In Storing Data");
            }
            con.Close();
        }
    }

}
