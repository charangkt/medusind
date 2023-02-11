using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp23
{
     class Program
    {

        public static SqlConnection conn;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        static void Main(string[] args)
        {
            SelectData();
            procData();
            Console.ReadLine();


        }

        static SqlConnection getConnection()
        {
            conn = new SqlConnection("data source=LAPTOP-RNFDJ0QL\\SQLEXPRESS;Initial Catalog=charan;" +
                "Integrated Security=true;");
            conn.Open();
            return conn;
        }
        static void SelectData()
        {
            try

            {
                conn = getConnection();
                cmd = new SqlCommand("select * from Code_employee where emsal >=25000", conn);
                dr = cmd.ExecuteReader();

                Console.WriteLine("************with out procedure*************** ");

                while (dr.Read())
                {
                    //Console.WriteLine(dr[0] + " | " + dr[1]+ " | " + dr[2] + " | " + dr[3]);
                    //or

                    Console.WriteLine("-------------");
                    Console.WriteLine("empno:" + dr[0]);
                    Console.WriteLine("empname:" + dr[1]);
                    Console.WriteLine("emsal:" + dr[2]);
                    Console.WriteLine("emptype:" + dr[3]);


                }
            }
            catch (SqlException se)
            {
                Console.WriteLine("Error Occured in the database.. Contact Admin");
            }
        }
        static void procData()
        {
            try
            {

                conn = getConnection();
                SqlCommand cmd = new SqlCommand("empo", conn);
                
             
                dr = cmd.ExecuteReader();


                while (dr.Read())
                {
                    //Console.WriteLine(dr[0] + " | " + dr[1]+ " | " + dr[2] + " | " + dr[3]);
                    //or
                    Console.WriteLine("-------------");
                    Console.WriteLine("empno:" + dr[0]);
                    Console.WriteLine("empname:" + dr[1]);
                    Console.WriteLine("emsal:" + dr[2]);
                    Console.WriteLine("emptype:" + dr[3]);


                }
            }
            catch (SqlException se2)
            {
                Console.WriteLine("Error Occured in the database.. Contact Admin");
            }
        }

    }
}
