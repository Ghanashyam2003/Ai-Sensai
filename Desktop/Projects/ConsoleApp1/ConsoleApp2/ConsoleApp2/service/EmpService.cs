using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.service
{
    

    internal class EmpService : IEmpService
    {
        SqlConnection conn;
        public EmpService()
        {
            conn = new SqlConnection("Data Source=localhost;Initial Catalog=StudentDB;Integrated Security=True;");
            conn.Open();
        }


        public void SaveEmp()
        {
            string ename, edept;
            double bsal;

            Console.WriteLine("Enter Name:");
            ename = Console.ReadLine();

            Console.WriteLine("Enter Department:");
            edept = Console.ReadLine();

            Console.WriteLine("Enter Salary:");
            bsal = double.Parse(Console.ReadLine());

            string query = $"exec sp_CRUD1 '{ename}','{bsal},'{edept}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();

            Console.WriteLine("Employee Saved Successfully");



        }


    }
}